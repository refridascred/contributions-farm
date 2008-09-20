using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Synced,
            Queued,
            New,
            Done,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long origin, long floor)
        {
            if (16 <= (floor + floor))
            {
                return 5;
            }
            else
            {
                if (floor <= (origin - floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor & 7) <= origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)floor > (double)66) || ((floor + floor) <= origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long seed, long target)
        {
            if ((5.7 + 16.0) >= (double)seed)
            {
                return 8;
            }
            else
            {
                if ((seed + target) < (seed % 16))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Pending,
            Paused,
        }
    }
}
