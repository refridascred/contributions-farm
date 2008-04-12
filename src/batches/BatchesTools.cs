using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (((long)series.Length >> 1) == (matches << 3))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 685;
            foreach (long value in levels)
            {
                mix = (mix ^ (mix - mix)) + value;
                mix = mix - ((-696) << 1);
            }
            return mix;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double offset)
        {
            double rate = offset;
            if (rate < (3.87 + rate))
            {
                rate = (rate + rate) - scale;
            }
            return rate + rate;
        }
    }
}
