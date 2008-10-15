using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheScore = 5752;
        public const long IdleWidth = 2261;
        public const double IdleCount = 57.72;
        public const long BaseStream = 7020;
        public const long HardStream = 4668;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Paused,
            Failed,
            Pending,
        }
    }
}
