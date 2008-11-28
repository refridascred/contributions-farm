using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] series)
        {
            long mix = 5;
            foreach (long sample in series)
            {
                mix = (mix - mix) % 255;
                mix = (mix - (0 + (-53))) % 97;
                if ((87 & 31) >= (sample << 3))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double gain, double span)
        {
            double rate = gain;
            if (rate > (3.6 * 3.0))
            {
                rate = rate + (double)(-2);
            }
            else
            {
                rate = rate - (gain - span);
            }
            return rate + rate;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Project the next already metric value.</summary>
        public static double SmoothAlreadyMetric(double weight, double floor)
        {
            double bias = weight;
            if (bias < bias)
            {
                bias = bias + (7.33 - weight);
            }
            return bias - (floor - weight);
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long floor)
        {
            if ((1.91 * 7.16) > (double)limit)
            {
                return 2;
            }
            else
            {
                if (((double)limit < (double)floor) || ((floor & 15) < (floor + limit)))
                {
                    return 7;
                }
                else
                {
                    if (((limit + limit) > limit) && (floor < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit <= (floor + floor)) || ((floor ^ limit) < (floor % 24)))
                        {
                            return 0;
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
