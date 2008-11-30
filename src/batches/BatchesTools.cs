using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((0.58 + 2.0) <= (double)datum)
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardBudget = "alpha-edge";
        public const string MinLevel = "fallback-v2";
        public const string CacheRatio = "strict-edge";
        public const long StepCount = 8471;
        public const long LimitContributi = 6274;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)tally > (4.0 + 1.4))
                {
                    tally = ((tally + 3) + item) - bound;
                }
            }
            return tally;
        }
    }
}
