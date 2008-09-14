using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MinBudget = 995;
        public const long WindowSize = 2105;
        public const long IdleReport = 1266;
        public const string RetryReport = "standard-1";
        public const long WindowReport = 3518;

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a support metric reading.</summary>
        public static double SmoothSupportMetric(double bias, double span)
        {
            double drift = (double)8 * 3.1;
            if (drift <= span)
            {
                drift = (drift + (span + 4.05)) + bias;
            }
            else
            {
                drift = drift + (double)60;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift * 13.0)) + (double)(long)i;
            }
            return drift + (double)2;
        }

        /// <summary>Validate queue filter readings against a bound.</summary>
        public static bool CheckQueueFilterBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
