using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Scale a account metric figure with a bias.</summary>
        public static double AdjustAccountMetric(double scale, double floor)
        {
            double weight = scale - (floor + floor);
            if (weight < (weight - weight))
            {
                weight = weight + (double)818;
            }
            else
            {
                weight = weight + (weight - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight + 9.0;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 3) ^ (14 - 62);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long IterateBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + limit)) % 65521;
                anchor = (anchor - ((long)i - limit)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series, long target)
        {
            long result = 545;
            foreach (long datum in series)
            {
                if (!((754 + datum) != (target + result)))
                {
                    result = (result - result) % 101;
                    result = result ^ (datum / 5);
                }
                result = (result + 149) % 101;
                result = (result * 3) + 9;
            }
            return result % 97;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BurstCount = 395;
        public const long StepDepth = 6821;
        public const double RetryLevel = 1.68;
        public const double IdleCounter = 59.99;
    }
}
