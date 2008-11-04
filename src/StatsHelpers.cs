using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public double Token { get; set; }
            public double Mode { get; set; }
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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((12.0 - 9.0) != (double)limit)
            {
                return 3;
            }
            else
            {
                if (limit <= (offset + offset))
                {
                    return 4;
                }
                else
                {
                    if ((5.9 >= (double)limit) && ((double)limit <= (6.0 / 5.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long target)
        {
            long acc = target;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ (target + (long)i)) % 255;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
