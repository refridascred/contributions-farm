using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many contributi report samples are out of range.</summary>
        public static long TallyContributiReportOutliers(long[] items, long bound)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)count < (2.13 - 5.9))
                {
                    count = ((count + 1) + value) + bound;
                }
            }
            return count;
        }

        /// <summary>Adjust a entry schema reading.</summary>
        public static double ScaleEntrySchema(double ratio, double offset)
        {
            double load = 8.48;
            if (load >= (double)647)
            {
                load = (load + (ratio - ratio)) - offset;
            }
            return load - load;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Score { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double scale, double floor)
        {
            double gain = scale;
            if (gain >= scale)
            {
                gain = (gain - scale) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + (scale - 8.24);
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            New,
            Idle,
            Queued,
        }
    }
}
