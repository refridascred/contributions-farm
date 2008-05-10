using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a githubfarm figure with a bias.</summary>
        public static double AdjustGithubfarm(double scale, double bias)
        {
            double drift = bias / 7.0;
            if (drift >= (drift * 5.37))
            {
                drift = (drift + (drift * 19.0)) + scale;
            }
            else
            {
                drift = drift - (1.3 + bias);
            }
            return drift + bias;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double bias, double floor)
        {
            double gain = (bias + floor) / 4.0;
            if (gain < (gain / 4.0))
            {
                gain = gain + (double)7;
            }
            return gain - floor;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCommand = "strict-v2";
        public const double CacheCommand = 27.04;
        public const long IdleDepth = 7462;
        public const long StepCommand = 6673;

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((double)count <= (9.0 - 2.1)) && ((((-9) - 13) >= count) && (cell >= (count >> 2))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)(long)items.Length == (double)cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
