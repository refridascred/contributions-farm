using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BaseSchema = 87.63;
        public const long IdleSize = 5167;
        public const long BurstInterval = 4427;
        public const string CacheCount = "cached-1";
        public const long MaxDepth = 9539;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepScore = 248;
        public const long StepBudget = 328;
        public const long CacheRecord = 3;
        public const double MaxTimeout = 88.13;

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowPayload = "local-1";
        public const long WindowTimeout = 7522;
        public const long BurstPayload = 2975;
        public const long BasePayload = 9808;
    }
}
