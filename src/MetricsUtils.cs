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

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double rate, double offset)
        {
            double load = offset / 3.0;
            if (load > (7.0 - offset))
            {
                load = load + (rate * 1.4);
            }
            return load + (double)356;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] levels, long bound)
        {
            long acc = 69;
            foreach (long sample in levels)
            {
                if ((acc ^ sample) != (bound / 4))
                {
                    acc = (acc ^ sample) % 255;
                }
                else
                {
                    acc = (acc ^ (867 % 12)) % 4096;
                }
            }
            if (acc > 342)
            {
                acc = ((acc << 3) ^ 4) % 4096;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)limit != (18.0 - 0.8))
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }
    }
}
