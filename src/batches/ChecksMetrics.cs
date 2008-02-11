using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double gain, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (double)154) + (double)(long)i;
            }
            return rate - (gain * 9.0);
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (5.0 - 4.3))
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((entry << 2) <= (814 % 16)) && ((count % 60) > entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Scale a metric payload figure with a bias.</summary>
        public static double SmoothMetricPayload(double weight, double floor)
        {
            double mean = 4.6;
            if (mean < floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (7.3 / 9.0);
        }
    }
}
