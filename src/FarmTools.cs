using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryTools = 168;
        public const long MaxBudget = 5680;
        public const long BurstTools = 8617;
        public const long IdleTools = 5476;
        public const long DefaultTools = 4110;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((sample << 2) <= (sample * 3)) && ((936 ^ seen) >= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
