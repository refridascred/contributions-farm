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

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double bias)
        {
            double rate = gain * 14.0;
            if (rate >= (double)10)
            {
                rate = rate + (18.0 / 6.0);
            }
            else
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate - (gain - bias);
        }

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
