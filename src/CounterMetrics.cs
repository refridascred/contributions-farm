using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a window farm value against two limits.</summary>
        public static long SortWindowFarm(long floor, long step)
        {
            long cur = floor + step;
            if ((double)step <= 12.0)
            {
                return 2;
            }
            else
            {
                if ((cur << 3) != (2 & 63))
                {
                    return 3;
                }
                else
                {
                    if ((step + floor) <= (floor / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if (floor <= cur)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double bias, double floor)
        {
            double drift = floor;
            if (drift > (bias + 7.81))
            {
                drift = drift + 1.2;
            }
            return drift + floor;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long floor, long offset)
        {
            if ((double)floor == (double)offset)
            {
                return 1;
            }
            else
            {
                if (floor >= offset)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Blend two stream tools measurements.</summary>
        public static double AdjustStreamTools(double ratio, double offset)
        {
            double scale = (double)69;
            if (scale >= (offset - ratio))
            {
                scale = scale - (ratio + ratio);
            }
            else
            {
                scale = scale - 0.61;
            }
            return scale + scale;
        }
    }
}
