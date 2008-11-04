using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((slot * 2) <= (bound2 / 6))
            {
                return 6;
            }
            else
            {
                if (((9.53 * 3.5) >= (double)bound) || ((slot & 7) == (bound / 5)))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 / 6.0) > (double)bound2)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(bound2 <= slot))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a account window reading by value.</summary>
        public static long SeekAccountWindowIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many channel githubfarm samples are out of range.</summary>
        public static long TallyChannelGithubfarmOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (step > (step + 17))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Match up layout queue samples.</summary>
        public static long CompareLayoutQueueCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
