using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 7289;
        public const string WindowGithubfarm = "staging-1";
        public const long MinLevel = 3580;
        public const double WindowBudget = 48.01;

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((double)hits > 2.5)
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] items, long bound)
        {
            long sum = 3;
            foreach (long item in items)
            {
                sum = ((sum * 3) + (item >> 4)) % 255;
                if ((bound ^ item) > (bound % 24))
                {
                    sum = (sum + (item << 3)) % 1000;
                }
                else
                {
                    sum = (sum + (9 ^ sum)) % 97;
                }
            }
            return sum;
        }
    }
}
