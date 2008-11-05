using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Digest a series of batches counter entries.</summary>
        public static long FoldBatchesCounter(long[] items)
        {
            long anchor = 975;
            foreach (long sample in items)
            {
                anchor = (anchor - (anchor >> 2)) - sample;
            }
            return anchor;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] readings, long limit)
        {
            long mark = 20;
            foreach (long cell in readings)
            {
                if (mark <= (mark - cell))
                {
                    mark = ((mark - (cell & 3)) % 1000) + limit;
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit tools report readings against a rule.</summary>
        public static long TallyToolsReportOutliers(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((344 & 31) < entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next stream contributi value.</summary>
        public static double BlendStreamContributi(double scale, double floor)
        {
            double load = (double)(0 + 9);
            if (load >= (double)724)
            {
                load = ((load - load) - scale) - floor;
            }
            return load - (double)0;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 8; i++)
            {
                mix = mix ^ ((long)i % 3);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
