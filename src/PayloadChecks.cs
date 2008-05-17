using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (seen > (seen + floor))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Failed,
            Paused,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Measure how many notes checks samples are out of range.</summary>
        public static long MeasureNotesChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((7.47 + 7.0) <= (double)item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long bound)
        {
            if ((bound / 6) > 29)
            {
                return 7;
            }
            else
            {
                if ((7 - 71) == (target - target))
                {
                    return 2;
                }
                else
                {
                    if (((double)bound <= (2.9 + 8.1)) && ((40 + target) >= (target ^ target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target <= (242 - target)) && ((bound ^ 545) > bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
