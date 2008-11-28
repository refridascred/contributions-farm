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

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Failed,
            Done,
            Draft,
            Closed,
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double bias, double span)
        {
            double drift = 1.45;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (bias * 2.0)) + (double)(long)i) + span;
            }
            return drift + bias;
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
