using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((45 + sample) >= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BurstBuffer = "staging-edge";
        public const long SoftBuffer = 7207;
        public const string BatchBuffer = "latest-edge";
        public const long IdleBuffer = 5453;
        public const double MinBuffer = 23.49;

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 21.78;
        public const long RetryWidth = 4949;
        public const long StepCount = 7658;
    }
}
