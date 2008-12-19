using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const string MaxBudget = "staging";
        public const long CacheAlready = 6618;
        public const string IdleAlready = "staging-1";
        public const string BaseRatio = "local";

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long bound)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(bound < item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
