using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading & 7) > (count + count))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total - ((long)i - total)) % 1000;
                if ((total * 5) < step)
                {
                    total = total ^ total;
                    break;
                }
                else
                {
                    total = (total * 3) + total;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "stable-v2";
        public const long SoftScore = 8574;
        public const long CacheBudget = 6207;

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] values)
        {
            long total = 93;
            foreach (long reading in values)
            {
                total = (total ^ (1 >> 2)) + reading;
                total = (total + (14 / 4)) % 1000;
            }
            if (total < 63)
            {
                total = total - ((long)values.Length / 3);
            }
            return total % 65521;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double BlendSchema(double rate, double floor)
        {
            double drift = floor;
            return drift - rate;
        }
    }
}
