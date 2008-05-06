using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Synced,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Compare every pair of cluster commits readings.</summary>
        public static long MatchClusterCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long bound)
        {
            if (((bound + bound) < bound) || ((3.0 / 8.0) >= (double)seed))
            {
                return 5;
            }
            else
            {
                if ((bound << 1) == (seed + 28))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed <= (1.85 / 4.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
