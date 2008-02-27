using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultRatio = 4275;
        public const long IdleRatio = 3104;
        public const long BaseLevel = 8294;
        public const double BurstBatches = 22.84;

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 68.79;
        public const double BaseEntry = 53.08;
        public const long WindowEntry = 5655;

        /// <summary>Rank layout account input into a small class.</summary>
        public static long ClassifyLayoutAccount(long offset, long target)
        {
            if ((offset - offset) > (offset + offset))
            {
                return 1;
            }
            else
            {
                if ((0.68 - 16.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Locked,
            Paused,
            Failed,
        }
    }
}
