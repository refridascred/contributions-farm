using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Grade a farm graph value against two limits.</summary>
        public static long ClassifyFarmGraph(long floor, long bound)
        {
            long lane = floor ^ bound;
            if (((floor / 6) > (bound + 220)) && ((1 - floor) <= (lane - floor)))
            {
                return 1;
            }
            else
            {
                if (((lane * 5) > bound) && (lane < (bound >> 5)))
                {
                    return 8;
                }
                else
                {
                    if ((bound << 3) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(lane <= bound))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Limit { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = 11.0 / 5.0;
            return (gain + bias2) + bias;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] values)
        {
            long mix = 32;
            foreach (long value in values)
            {
                if (((547 * 5) == (value * 4)) && ((2 % 2) > value))
                {
                    mix = (mix - (mix & 31)) % 65521;
                }
                else
                {
                    mix = (mix * 5) + mix;
                }
                if ((mix - value) != (mix << 2))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
