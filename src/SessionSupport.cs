using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 109;
        public const long SoftBatches = 6456;
        public const long DefaultCount = 5032;
        public const long CacheBatches = 9198;

        /// <summary>Project the next githubfarm value.</summary>
        public static double AdjustGithubfarm(double ratio, double floor)
        {
            double ratio2 = (double)((-8) + 839);
            if (ratio2 > (floor - ratio))
            {
                ratio2 = ratio2 + (floor * 0.05);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Audit format cache readings against a rule.</summary>
        public static long CountFormatCacheMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((64 + value) > (tally + 369))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
