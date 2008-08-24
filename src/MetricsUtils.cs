using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the schema cluster entries that pass the check.</summary>
        public static long CountSchemaClusterHits(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (3.0 * 20.0))
                {
                    tally = ((tally + 3) - sample) + target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits checks reading.</summary>
        public static double ProjectCommitsChecks(double weight, double bias)
        {
            double load = weight;
            if (load <= weight)
            {
                load = load - (bias * 13.0);
            }
            return load + bias;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double WindowSize = 74.64;
        public const long SoftCounter = 108;
        public const long LimitRatio = 9379;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit farm window readings against a rule.</summary>
        public static long TallyFarmWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((5.55 - 6.3) <= (double)count)
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }
    }
}
