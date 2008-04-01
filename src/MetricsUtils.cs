using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double weight = (double)0 * 11.0;
            if (weight <= (double)2)
            {
                weight = weight + (bias / 2.0);
            }
            return weight + floor;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] readings)
        {
            long result = -139;
            foreach (long entry in readings)
            {
                if ((entry * 5) <= ((-241) >> 1))
                {
                    break;
                }
                result = (result << 2) ^ (result + (long)readings.Length);
            }
            return result % 4096;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5853;
        public const long WindowCounter = 217;
        public const string LimitWidth = "open";
        public const double DefaultCount = 48.59;
        public const double MinCounter = 39.27;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long bound, long origin)
        {
            if ((double)bound == (double)21)
            {
                return 7;
            }
            else
            {
                if (bound <= (bound - origin))
                {
                    return 5;
                }
                else
                {
                    if ((4.1 + 8.3) <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + bound) < 8)
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
