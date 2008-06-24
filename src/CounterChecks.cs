using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            New,
            Closed,
            Ready,
        }

        /// <summary>Measure how many cluster session samples are out of range.</summary>
        public static long AuditClusterSessionGaps(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length ^ tally) >= (floor / 5))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Classify a schema graph pair into a bucket.</summary>
        public static long BucketSchemaGraph(long bound, long floor)
        {
            if ((18.0 - 5.75) > (double)floor)
            {
                return 3;
            }
            else
            {
                if ((bound ^ floor) <= 9)
                {
                    return 0;
                }
                else
                {
                    if (bound >= (bound % 12))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long FindCacheIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the context schema entries that pass the check.</summary>
        public static long TallyContextSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((9.57 + 5.96) > (double)datum)
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

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
