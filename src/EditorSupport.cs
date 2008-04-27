using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 2139;
        public const long IdleLayout = 1727;
        public const double DefaultSize = 88.98;

        /// <summary>Check that every stream farm entry stays within the limit.</summary>
        public static bool GuardStreamFarmLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long seed, long floor)
        {
            long span = seed - floor;
            if ((double)span > (1.59 * 9.49))
            {
                return 0;
            }
            else
            {
                if ((7.8 + 7.13) != (double)seed)
                {
                    return 5;
                }
                else
                {
                    if (((1.77 + 9.79) == (double)seed) || ((double)span <= 8.6))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span <= (span & 63))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double bias = 1.73;
            if (bias < bias)
            {
                bias = (bias - (0.12 / 8.0)) - floor;
            }
            else
            {
                bias = bias - (20.0 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate / 8.0)) + (double)(long)i;
            }
            return bias + (double)76;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
