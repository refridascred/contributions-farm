using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Queued,
            Closed,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryAlready = 6365;
        public const long WindowAlready = 1736;
        public const long IdleFactor = 9681;
        public const string MaxBudget = "standard-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const string CacheGraph = "fallback-edge";
        public const long WindowGraph = 6213;
        public const string SoftGraph = "local-v2";
        public const long CacheBudget = 6394;
        public const string HardGraph = "staging-v2";

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long step)
        {
            long anchor = 54;
            foreach (long reading in data)
            {
                anchor = (anchor * 3) + (reading * 3);
            }
            if (anchor > 41)
            {
                anchor = (anchor << 2) ^ (5 + step);
            }
            return anchor;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((offset / 9) >= (result + (long)i))
                {
                    result = (result ^ offset) % 97;
                }
                else
                {
                    long bound = (long)i ^ (0 + 194);
                    result = result + (bound ^ 327);
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
