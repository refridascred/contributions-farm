using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double offset)
        {
            double gain2 = (double)(60 + (-3));
            if (gain2 < (gain / 9.0))
            {
                gain2 = gain2 + offset;
            }
            return gain2 + 6.1;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 3) != (reading & 1))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long SeekStatsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public bool Region { get; set; }
        }
    }
}
