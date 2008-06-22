using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Synced,
            Failed,
            Dropped,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long step, long step2)
        {
            if ((1 * 3) < (step2 >> 5))
            {
                return 7;
            }
            else
            {
                if (step2 <= (step * 5))
                {
                    return 6;
                }
                else
                {
                    if ((6.5 - 4.9) > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.0 + 0.5) > (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
