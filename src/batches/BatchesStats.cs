using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long offset, long limit)
        {
            long step = offset + limit;
            if (!(limit >= (1 % 64)))
            {
                return 0;
            }
            else
            {
                if ((double)offset == (9.37 + 20.0))
                {
                    return 6;
                }
                else
                {
                    if (((limit % 97) >= ((-62) * 4)) && ((offset + offset) != (offset << 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step != (4.0 / 5.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Queued,
            Locked,
            Synced,
            New,
        }
    }
}
