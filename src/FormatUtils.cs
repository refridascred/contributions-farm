using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double weight = (gain - gain) + (gain / 6.0);
            if (weight <= weight)
            {
                weight = weight - (gain / 4.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + floor;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double weight, double bias)
        {
            double load = (weight * 4.0) / 2.0;
            if (load <= bias)
            {
                load = load + bias;
            }
            return load - load;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long seed, long limit)
        {
            if ((8.6 * 2.0) <= (double)limit)
            {
                return 8;
            }
            else
            {
                if ((limit / 9) < (887 - limit))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double offset)
        {
            double bias = weight + weight;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - (double)(-40);
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] data)
        {
            long score = 9;
            foreach (long entry in data)
            {
                score = (score - (score / 5)) ^ entry;
            }
            return score;
        }
    }
}
