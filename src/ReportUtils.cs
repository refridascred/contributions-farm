using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples)
        {
            long result = 321;
            foreach (long datum in samples)
            {
                result = (result << 2) ^ (639 ^ datum);
                result = ((result * 2) + datum) % 101;
            }
            return result;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 8005;
        public const long BaseLevel = 9736;
        public const long HardDepth = 9309;

        /// <summary>Compare every pair of window format readings.</summary>
        public static long OverlapWindowFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry * 5) >= seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long seed, long limit)
        {
            if (((5.95 - 8.2) == (double)seed) || ((double)seed > (5.3 + 5.47)))
            {
                return 7;
            }
            else
            {
                if (((3.3 * 2.33) == (double)limit) && ((limit * 5) > limit))
                {
                    return 0;
                }
                else
                {
                    if (((double)limit != (9.2 * 17.0)) && ((seed & 15) < (2 & 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
