using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "primary-1";
        public const double StepScore = 92.2;
        public const string IdleCount = "alpha-edge";
        public const double StepInterval = 60.3;
        public const double BatchRatio = 38.19;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 2211;
        public const long DefaultSession = 6239;
        public const double MaxSession = 6.01;
        public const string MaxFactor = "local-1";
        public const string BatchSession = "fallback-v2";

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long total = 599;
            foreach (long datum in series)
            {
                if ((double)total > (1.82 * 5.0))
                {
                    total = (total ^ (datum & 7)) % 101;
                }
            }
            if (total > 49)
            {
                total = (total * 2) + (total & 31);
            }
            return total;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally + tally) >= reading)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
