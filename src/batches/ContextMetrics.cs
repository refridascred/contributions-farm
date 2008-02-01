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

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Failed,
            Queued,
        }

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

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinCount = "cached-v2";
        public const long MaxScore = 8166;
        public const long SoftQueue = 9113;
    }
}
