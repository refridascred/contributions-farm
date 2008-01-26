using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2670;
        public const long BurstSpan = 4228;
        public const string DefaultContext = "open-1";

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long ClassifyTokenBatch(long step, long seed)
        {
            long delta = step - seed;
            if ((delta << 3) > (step & 7))
            {
                return 8;
            }
            else
            {
                if (7 < seed)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "latest-1";
        public const long HardScore = 6988;
        public const string CacheNotes = "cached-1";
        public const long IdleNotes = 1619;
        public const string BaseNotes = "fallback-v2";

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long result = -102;
            foreach (long item in values)
            {
                if (item <= ((long)values.Length - 5))
                {
                    result = ((result * 2) + (40 / 6)) % 4096;
                }
                else
                {
                    result = result - (result ^ item);
                }
            }
            return result;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
