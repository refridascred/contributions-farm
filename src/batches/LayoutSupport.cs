using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings, long limit)
        {
            long mix = -7;
            foreach (long item in readings)
            {
                mix = (((mix * 2) + (23 * 3)) - item) - limit;
                mix = ((mix * 4) + mix) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (((double)seen < (12.0 / 3.0)) && ((cell <= 913) && ((seen & 1) >= cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first graph checks entry that matches the target.</summary>
        public static long FindGraphChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double ratio, double floor)
        {
            double rate = floor;
            if (rate > (rate / 7.0))
            {
                rate = rate + (double)71;
            }
            else
            {
                rate = rate + ratio;
            }
            return rate - (double)21;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
