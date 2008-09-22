using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long result = origin;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length >= (8.0 / 8.0))
                {
                    mix = (mix - (item * 4)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftProfile = 86.7;
        public const long MaxProfile = 6122;
        public const double BaseBudget = 68.89;
        public const long RetrySize = 5110;

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long origin)
        {
            long step = seed ^ origin;
            if (!((origin % 64) > origin))
            {
                return 7;
            }
            else
            {
                if (seed >= (step + seed))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxDepth = 32.56;
        public const string DefaultContributi = "legacy-v2";
        public const long MinContributi = 3607;

        /// <summary>Adjust a report account reading.</summary>
        public static double ProjectReportAccount(double weight, double floor)
        {
            double mean = (double)6;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (double)6) + (double)(long)i) + weight;
            }
            return mean + floor;
        }
    }
}
