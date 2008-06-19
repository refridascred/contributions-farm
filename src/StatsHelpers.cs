using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Stale,
            Queued,
            Dropped,
            Closed,
            Idle,
        }

        /// <summary>Rank farm window input into a small class.</summary>
        public static long GradeFarmWindow(long offset, long offset2)
        {
            long bound = offset - offset2;
            if (bound >= (bound / 3))
            {
                return 3;
            }
            else
            {
                if ((double)bound <= (double)offset2)
                {
                    return 2;
                }
                else
                {
                    if (offset2 > (offset >> 3))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)offset == (13.0 * 8.53)) && ((offset2 ^ offset2) >= (-34)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long offset, long target)
        {
            long slot = offset + target;
            if ((offset % 8) > slot)
            {
                return 4;
            }
            else
            {
                if (((double)slot == (double)target) && ((double)slot <= (6.38 - 4.6)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Stamp { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] data, long step)
        {
            long mark = 7;
            foreach (long value in data)
            {
                mark = (mark + (value * 3)) - step;
            }
            return mark % 1000;
        }
    }
}
