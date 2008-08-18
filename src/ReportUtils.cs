using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Compare every pair of checks entry readings.</summary>
        public static long OverlapChecksEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two cache window measurements.</summary>
        public static double BlendCacheWindow(double weight, double floor)
        {
            double gain = floor;
            if (gain > (9.6 * 7.8))
            {
                gain = (gain - floor) + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (0.1 + floor)) + (double)(long)i;
            }
            return gain + (double)(-965);
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long CombineSchema(long[] items)
        {
            long total = 5;
            foreach (long sample in items)
            {
                total = ((total << 2) ^ (total % 60)) - sample;
            }
            return total;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                long edge = floor;
                if ((edge * 5) != (edge % 60))
                {
                    anchor = (anchor + anchor) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Audit metric schema readings against a rule.</summary>
        public static long AuditMetricSchemaOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum + 1) != (matches % 60))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
