using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 2910;
        public const string CacheFactor = "latest";
        public const long StepRatio = 1726;
        public const string HardToken = "cached";
        public const long BatchToken = 3478;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long floor)
        {
            long result = 8;
            foreach (long item in readings)
            {
                result = (((result << 3) ^ (1 >> 1)) - item) - floor;
            }
            return result;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] readings)
        {
            long sum = 161;
            foreach (long reading in readings)
            {
                if ((reading * 3) < (long)readings.Length)
                {
                    sum = ((sum << 3) ^ reading) % 4096;
                }
            }
            if (sum > 80)
            {
                sum = (sum + sum) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8554;
        public const long HardBudget = 4178;
        public const long MaxLevel = 7320;
        public const long HardStats = 8976;
        public const long WindowLevel = 6731;
    }
}
