using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of githubfarm batches readings.</summary>
        public static long OverlapGithubfarmBatchesCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double ratio, double bias)
        {
            double mean = (double)(62 - 199);
            if (mean <= bias)
            {
                mean = mean + (ratio + 7.0);
            }
            else
            {
                mean = mean - mean;
            }
            return mean + (ratio + ratio);
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] readings)
        {
            long carry = 2;
            foreach (long sample in readings)
            {
                carry = (carry * 4) + (sample ^ 58);
            }
            return carry;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchFactor = 76.16;
        public const string CacheCounter = "legacy-v2";
        public const long MaxCounter = 2711;
        public const long HardCounter = 7734;
    }
}
