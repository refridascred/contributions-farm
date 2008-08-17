using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Paused,
            Locked,
            Failed,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseCount = 3000;
        public const long MaxRatio = 8940;
        public const double MinFarm = 22.43;
        public const double HardBudget = 36.35;
        public const long RetryFarm = 2206;
    }
}
