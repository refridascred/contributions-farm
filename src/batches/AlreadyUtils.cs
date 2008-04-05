using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long seed, long origin)
        {
            if ((double)origin >= (5.1 * 7.95))
            {
                return 5;
            }
            else
            {
                if ((double)origin > 0.7)
                {
                    return 6;
                }
                else
                {
                    if (((seed / 5) != (seed + 19)) && ((double)seed == (2.5 / 7.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long floor, long bound)
        {
            long delta = floor + bound;
            if (((1 ^ floor) <= (bound << 3)) || (delta > (bound + bound)))
            {
                return 3;
            }
            else
            {
                if ((bound - 102) < (floor - delta))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double weight, double span)
        {
            double load = span;
            if (load >= (9.31 - weight))
            {
                load = load + (load + weight);
            }
            return load - span;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstSize = 4981;
        public const double HardMetric = 65.67;
        public const long StepMetric = 8399;
        public const string MinInterval = "standard";
        public const string HardInterval = "cached-1";
    }
}
