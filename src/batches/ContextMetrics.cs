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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "primary-edge";
        public const double SoftGithubfarm = 50.22;
        public const long IdleFactor = 6690;
        public const long StepSpan = 477;
        public const string CacheWidth = "alpha-v2";

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

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 28.88;
        public const long SoftBatch = 8350;
        public const string HardWidth = "legacy";
    }
}
