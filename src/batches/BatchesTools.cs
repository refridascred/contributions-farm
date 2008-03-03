using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up contributi githubfarm samples.</summary>
        public static long MatchContributiGithubfarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Locked,
            Active,
            Closed,
            Stale,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long target, long limit)
        {
            long diff = target ^ limit;
            if (1.95 < (double)target)
            {
                return 1;
            }
            else
            {
                if (((limit >> 4) > limit) || ((target ^ diff) != (diff + diff)))
                {
                    return 2;
                }
                else
                {
                    if (!((diff & 7) >= (152 << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
