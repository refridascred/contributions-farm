using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            New,
            Retry,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] levels)
        {
            long result = 44;
            foreach (long cell in levels)
            {
                if ((result & 255) >= (result + result))
                {
                    result = (result + (result - 9)) % 1000;
                }
                result = (result * 2) + result;
                if ((((long)levels.Length / 2) >= (result + cell)) || ((result + result) != (result / 7)))
                {
                    break;
                }
            }
            return result % 65521;
        }
    }
}
