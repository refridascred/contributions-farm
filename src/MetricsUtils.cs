using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double weight, double offset)
        {
            double bias = (1.5 - weight) / 6.0;
            if (bias <= weight)
            {
                bias = bias - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + weight) + (double)(long)i;
            }
            return bias + offset;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long floor)
        {
            if ((floor + floor) > floor)
            {
                return 7;
            }
            else
            {
                if ((double)bound != (0.8 + 2.4))
                {
                    return 4;
                }
                else
                {
                    if ((bound > 987) && ((bound / 5) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor > (5.0 - 16.0)) || ((bound & 255) <= (floor & 127)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 5158;
        public const long WindowSize = 9288;
        public const double BurstWidth = 44.97;
        public const double StepDepth = 51.5;
        public const long MaxFarm = 9808;

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRatio = 3753;
        public const long BatchWidth = 376;
        public const long BatchRoute = 7700;
        public const long BaseRoute = 4778;
    }
}
