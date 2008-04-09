using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a profile context reading.</summary>
        public static double ProjectProfileContext(double ratio, double offset)
        {
            double mean = (double)44 / 7.0;
            return ((mean + (double)508) + ratio) + offset;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long seed)
        {
            long bound = origin - seed;
            if (((seed ^ origin) <= (1 % 64)) || ((origin + bound) >= bound))
            {
                return 3;
            }
            else
            {
                if ((origin - bound) == (seed + origin))
                {
                    return 4;
                }
                else
                {
                    if ((0.44 - 18.0) <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)bound > (12.0 * 4.3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Ready,
            New,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (992 + 918))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
