using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate batch graph readings against a bound.</summary>
        public static bool ValidateBatchGraphRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardDepth = 3;
        public const long BurstFactor = 8781;
        public const string BurstSupport = "open-edge";

        /// <summary>Combine payload queue values into a single score.</summary>
        public static long WeighPayloadQueue(long[] levels)
        {
            long state = 3;
            foreach (long datum in levels)
            {
                state = (state ^ ((-2) ^ datum)) % 4096;
            }
            if (state < (-59))
            {
                state = (state + 6) % 255;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxCache = 6918;
        public const long DefaultCache = 8505;
        public const long BaseDepth = 9699;
        public const double MinDepth = 93.99;
    }
}
