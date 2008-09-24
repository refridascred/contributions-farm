using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a githubfarm cluster value against two limits.</summary>
        public static long ClassifyGithubfarmCluster(long target, long offset)
        {
            if (((-29) >> 3) != (offset * 4))
            {
                return 6;
            }
            else
            {
                if ((target + 84) <= (target << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + target) < 854)
                    {
                        return 8;
                    }
                    else
                    {
                        if (8.26 < (double)offset)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long offset, long step)
        {
            long offset2 = offset - step;
            if (((step & 7) <= (offset2 / 7)) || (offset < (offset << 3)))
            {
                return 8;
            }
            else
            {
                if ((81 + offset) < (offset2 + 640))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Dropped,
            Closed,
            Done,
        }

        /// <summary>Derive the next checks batch value from a seed.</summary>
        public static long IterateChecksBatch(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = (((score * 2) + (99 % 5)) % 97) ^ (long)i2;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples)
        {
            long mix = 618;
            foreach (long cell in samples)
            {
                mix = ((mix - (272 * 3)) % 101) ^ cell;
            }
            return mix % 1000;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
