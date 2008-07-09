using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a report session reading by value.</summary>
        public static long LocateReportSessionIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every order layout entry stays within the limit.</summary>
        public static bool ValidateOrderLayoutRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Active,
            New,
            Queued,
            Closed,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((floor - datum) < (floor << 3)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] values)
        {
            long acc = -99;
            foreach (long reading in values)
            {
                acc = acc - (reading - reading);
            }
            if (acc < (-63))
            {
                acc = (acc << 2) ^ 1;
            }
            return acc;
        }

        /// <summary>Classify a commits tools pair into a bucket.</summary>
        public static long ClassifyCommitsTools(long offset, long step)
        {
            if ((double)step < (4.8 / 6.0))
            {
                return 1;
            }
            else
            {
                if ((offset * 2) < (offset / 3))
                {
                    return 5;
                }
                else
                {
                    if ((step >= (step / 6)) && (offset < (offset / 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
