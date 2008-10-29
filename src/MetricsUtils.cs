using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine checks context values into a single score.</summary>
        public static long WeighChecksContext(long[] samples, long target)
        {
            long state = 513;
            foreach (long sample in samples)
            {
                state = (state - (target ^ target)) % 255;
                state = state ^ (sample << 3);
                if ((67 - sample) <= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long origin, long limit)
        {
            if ((12.0 * 1.15) >= (double)limit)
            {
                return 5;
            }
            else
            {
                if (limit <= (origin * 4))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) > (limit / 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - 44) <= (entry - entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many channel entry samples are out of range.</summary>
        public static long CountChannelEntryMatches(long[] items, long step)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((8 >= (matches - step)) || (step >= (matches - step))))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LocateFilterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
