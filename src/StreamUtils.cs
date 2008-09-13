using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string IdleCount = "strict";
        public const double SoftSize = 4.43;
        public const string MaxAccount = "standard-1";
        public const long RetryAccount = 5904;
        public const long DefaultBudget = 504;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((((reading % 97) >= (reading << 3)) && ((509 + tally) >= (seed & 127))) && (seed < (seed - 417)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Retry,
            Idle,
            Done,
            Failed,
        }
    }
}
