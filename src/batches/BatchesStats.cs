using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Owner { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long step)
        {
            if (((79 + target) >= (step - target)) && ((target - target) == (64 << 2)))
            {
                return 3;
            }
            else
            {
                if ((target >> 4) <= step)
                {
                    return 0;
                }
                else
                {
                    if ((target + step) == (target + (-65)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double weight, double offset)
        {
            double scale = offset / 3.0;
            if (scale < (double)411)
            {
                scale = (scale - (double)17) - weight;
            }
            return scale - scale;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long offset, long origin)
        {
            long cur = offset ^ origin;
            if ((origin ^ 965) >= cur)
            {
                return 3;
            }
            else
            {
                if (!((double)cur <= (double)47))
                {
                    return 8;
                }
                else
                {
                    if ((offset <= (origin >> 1)) && ((cur % 60) <= (cur - origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((cur + origin) > (origin >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
