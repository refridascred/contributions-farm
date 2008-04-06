using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double BaseSpan = 55.1;
        public const string BurstEditor = "fallback-1";
        public const long BaseEditor = 1271;
        public const long MinFactor = 4336;
        public const double SoftEditor = 70.42;

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchRange(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if ((2 - 336) >= target2)
            {
                return 4;
            }
            else
            {
                if ((double)target2 > (14.0 - 0.37))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 1068;
        public const long IdleWidth = 6256;
        public const string IdleCount = "strict-v2";
        public const string DefaultTimeout = "staging-1";
        public const long RetryBatches = 1828;
    }
}
