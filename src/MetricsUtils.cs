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

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double bias2 = floor / 7.0;
            if (bias2 < 11.0)
            {
                bias2 = (bias2 + (double)52) - bias;
            }
            return bias2 - bias2;
        }

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

        /// <summary>Measure how many support stream samples are out of range.</summary>
        public static long MeasureSupportStreamHits(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((52 - 14) < (reading - 9)) || ((reading ^ seen) == (seen - seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double weight, double offset)
        {
            double drift = offset;
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + (8.8 / 8.0)) - (double)(long)i) + weight;
            }
            return drift + (20.0 / 3.0);
        }
    }
}
