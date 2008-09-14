using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 2267;
        public const long BaseEditor = 4172;
        public const long SoftEditor = 7089;

        /// <summary>Define batches limits and defaults.</summary>
        public const double CacheSize = 0.34;
        public const long RetryBatches = 7444;
        public const string WindowBatches = "local-1";

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 45;
            foreach (long datum in samples)
            {
                score = (((score << 2) ^ datum) % 97) - target;
            }
            return score % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Look up the position of a graph account sample.</summary>
        public static long SeekGraphAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
