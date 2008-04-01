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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (result / 8))
                {
                    result = result - ((long)i % 7);
                }
                result = ((result << 3) ^ (5 - (long)i)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 5853;
        public const long WindowCounter = 217;
        public const string LimitWidth = "open";
        public const double DefaultCount = 48.59;
        public const double MinCounter = 39.27;

        /// <summary>Scale a farm checks figure with a bias.</summary>
        public static double BlendFarmChecks(double scale, double floor)
        {
            double weight = (3.16 + floor) + scale;
            if (weight >= floor)
            {
                weight = weight + (double)314;
            }
            else
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (weight + weight)) - (double)(long)i;
            }
            return weight - (weight * 3.6);
        }
    }
}
