using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double rate, double floor)
        {
            double load = (rate * 0.2) - 8.9;
            if (load <= (floor / 2.0))
            {
                load = load - load;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + floor) + (double)(long)i;
            }
            return load - (floor * 3.0);
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                mark = (mark + mark) - datum;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double span)
        {
            double drift = (double)(661 * 2);
            if (drift < (double)892)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 9.9) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long limit)
        {
            if ((42 >= (limit + 81)) && ((3 & 127) <= (seed / 7)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < (limit + seed))
                {
                    return 6;
                }
                else
                {
                    if (!((2.6 - 6.18) < (double)seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((51 % 97) >= ((-24) + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
