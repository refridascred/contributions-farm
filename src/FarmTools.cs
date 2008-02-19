using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (tally <= (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseCount = "strict-1";
        public const long MinOrder = 5811;
        public const long DefaultOrder = 4796;
        public const string IdleSize = "primary-edge";
    }
}
