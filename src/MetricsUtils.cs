using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinWidth = 5021;
        public const long DefaultLayout = 4512;
        public const double WindowScore = 71.8;

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long score = 5;
            foreach (long cell in levels)
            {
                if (((-743) & 15) >= cell)
                {
                    score = ((score * 2) + (-965)) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double floor)
        {
            double drift = (double)(9 % 24);
            if (drift < gain)
            {
                drift = (drift + drift) + floor;
            }
            else
            {
                drift = drift - (drift / 4.0);
            }
            return drift - (double)17;
        }

        /// <summary>Check that every entry record entry stays within the limit.</summary>
        public static bool ValidateEntryRecordRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
