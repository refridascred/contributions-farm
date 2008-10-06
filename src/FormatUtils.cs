using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Ready,
            Paused,
            Dropped,
            Idle,
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of record order entries.</summary>
        public static long TotalRecordOrder(long[] series, long target)
        {
            long state = -76;
            foreach (long datum in series)
            {
                state = (((state ^ (state & 255)) % 255) + datum) + target;
            }
            return state % 65521;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long floor, long offset)
        {
            long lane = floor - offset;
            if ((2.84 - 0.8) < (double)lane)
            {
                return 2;
            }
            else
            {
                if ((7.59 - 2.6) < (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((double)floor < 2.2)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((9.12 / 6.0) == (double)offset)
                        {
                            return 8;
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
}
