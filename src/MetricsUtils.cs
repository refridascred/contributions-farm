using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long mix = 1;
            foreach (long reading in levels)
            {
                if (!(mix >= reading))
                {
                    mix = (mix ^ mix) % 101;
                }
                if (!((reading >> 4) < (84 << 2)))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = mix + (mix + mix);
            }
            return mix;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long target)
        {
            long offset = origin ^ target;
            if (!((target ^ origin) >= 282))
            {
                return 3;
            }
            else
            {
                if ((23 * 4) > (target + target))
                {
                    return 4;
                }
                else
                {
                    if ((offset ^ offset) == (target << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + target) <= 88)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Ratio { get; set; }
            public string Count { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Check that every batch contributi entry stays within the limit.</summary>
        public static bool CheckBatchContributiBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
