using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double BurstGithubfarm = 62.93;
        public const long BaseGithubfarm = 4807;
        public const long CacheInterval = 906;
        public const long StepFactor = 709;

        /// <summary>Compare every pair of queue farm readings.</summary>
        public static long CompareQueueFarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen & 3) <= 135)
                {
                    seen = ((seen + 3) ^ entry) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
