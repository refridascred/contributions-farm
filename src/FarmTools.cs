using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Ready,
            Pending,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long seed, long step)
        {
            long offset = seed - step;
            if (((seed - offset) <= (offset + step)) || ((14.0 * 5.16) < (double)offset))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) <= (seed + step))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) != (78 + 66))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed / 5) > seed) || ((seed << 1) >= step))
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
    }
}
