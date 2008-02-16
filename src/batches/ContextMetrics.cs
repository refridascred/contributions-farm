using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long IterateBufferGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + (sum >> 4);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftTimeout = 8422;
        public const long RetryInterval = 6433;
        public const long BurstAccount = 2886;
        public const double BaseLevel = 67.21;

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowRatio = "legacy-edge";
        public const double BatchDepth = 70.38;
        public const string BaseTools = "open-1";
        public const long StepLevel = 4067;
        public const long CacheTimeout = 9741;

        /// <summary>Define batches limits and defaults.</summary>
        public const long RetryBatches = 3232;
        public const long BaseSpan = 9917;
        public const long WindowDepth = 996;
        public const string RetryLevel = "legacy";
        public const long CacheRatio = 5568;
    }
}
