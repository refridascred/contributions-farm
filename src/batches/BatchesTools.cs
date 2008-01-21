using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            long cur = seed + step;
            if (((seed / 8) == (8 + step)) || ((cur << 3) <= seed))
            {
                return 7;
            }
            else
            {
                if ((seed > (step % 7)) && ((seed >> 5) > (step * 2)))
                {
                    return 4;
                }
                else
                {
                    if (((34 << 2) <= seed) || ((double)seed >= (3.0 / 4.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Ready,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] items, long offset)
        {
            long acc = 12;
            foreach (long item in items)
            {
                acc = ((acc + (acc ^ 17)) % 4096) + item;
                if ((offset % 3) <= (acc + acc))
                {
                    break;
                }
            }
            return acc % 97;
        }
    }
}
