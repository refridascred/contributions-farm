using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Blend two metric format measurements.</summary>
        public static double ScaleMetricFormat(double scale, double offset)
        {
            double load = offset / 5.0;
            if (load > load)
            {
                load = (load - (double)1) - scale;
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (2.8 * 6.86)) - (double)(long)i;
            }
            return load - (11.0 * 1.7);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Flag { get; set; }
            public bool Region { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Draft,
            New,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum / 5) <= (origin * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout metrics value from a seed.</summary>
        public static long StepLayoutMetrics(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (limit - limit)) % 97;
                total = ((total << 2) ^ (4 + (long)i)) % 97;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
