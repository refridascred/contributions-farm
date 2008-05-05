using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public double Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank githubfarm channel input into a small class.</summary>
        public static long RankGithubfarmChannel(long step, long seed)
        {
            long slot = step ^ seed;
            if (((slot & 1) == (seed % 60)) && (228 < step))
            {
                return 0;
            }
            else
            {
                if (slot < (step & 255))
                {
                    return 3;
                }
                else
                {
                    if ((step >= (slot / 6)) || ((seed * 2) <= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed / 4) == (step - slot))
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many cache queue samples are out of range.</summary>
        public static long TallyCacheQueueOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)matches != (5.6 + 20.0))
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }
    }
}
