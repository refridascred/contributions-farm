using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double load = floor;
            if (load > load)
            {
                load = load - scale;
            }
            return load - scale;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamHits(long[] series, long seed)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (seen < (18 % 24))
                {
                    seen = ((seen + 2) - value) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Queued,
            Paused,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double bias)
        {
            double gain2 = gain / 2.0;
            if (gain2 >= (gain - 0.61))
            {
                gain2 = gain2 - (gain * 3.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain2 * 8.85)) + (double)(long)i;
            }
            return gain2 - bias;
        }
    }
}
