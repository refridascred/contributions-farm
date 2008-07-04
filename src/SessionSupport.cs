using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Retry,
            Synced,
            Dropped,
            Failed,
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < span)
            {
                ratio2 = ratio2 - (ratio + 2.7);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 + (double)945) + (double)(long)i;
            }
            return ratio2 + ratio;
        }
    }
}
