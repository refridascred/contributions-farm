using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of filter metrics entries.</summary>
        public static long TallyFilterMetrics(long[] values)
        {
            long sum = 379;
            foreach (long entry in values)
            {
                sum = ((sum - (-413)) % 65521) + entry;
            }
            return sum % 1000;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] readings)
        {
            long anchor = 13;
            foreach (long datum in readings)
            {
                anchor = (anchor ^ anchor) + datum;
            }
            if (anchor > 130)
            {
                anchor = anchor + (long)readings.Length;
            }
            return anchor;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count << 1) < (30 + sample))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }
    }
}
