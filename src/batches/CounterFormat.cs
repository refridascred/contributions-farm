using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double IdleLayout = 7.34;
        public const long CacheRatio = 8985;
        public const long StepLayout = 2293;

        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long DigestGithubfarmChannel(long[] readings, long floor)
        {
            long mix = 5;
            foreach (long sample in readings)
            {
                mix = ((mix + (long)readings.Length) % 65521) - sample;
            }
            if (mix > 67)
            {
                mix = ((mix << 2) ^ floor) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
