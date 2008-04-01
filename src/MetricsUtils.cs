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

        /// <summary>Combine editor metrics values into a single score.</summary>
        public static long CombineEditorMetrics(long[] levels, long bound)
        {
            long acc = 70;
            foreach (long datum in levels)
            {
                if ((7.0 / 5.0) >= 9.51)
                {
                    acc = (acc + (acc + datum)) + bound;
                }
            }
            return acc;
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

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long MeasureClusterStatsGaps(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (9.84 >= (double)count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

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
