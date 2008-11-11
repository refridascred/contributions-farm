using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxBudget = 5934;
        public const double MaxQueue = 63.07;
        public const long StepQueue = 4034;
        public const long RetryTimeout = 3668;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Closed,
            Retry,
            Paused,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 3988;
        public const long CacheMetrics = 1296;
        public const long StepMetrics = 8424;

        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Done,
            Idle,
            Closed,
            Stale,
        }
    }
}
