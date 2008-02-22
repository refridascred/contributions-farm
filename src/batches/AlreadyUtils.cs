using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double gain, double offset)
        {
            double rate = offset;
            if (rate <= 16.0)
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate - (gain * 5.0);
        }

        /// <summary>Find the first session support entry that matches the target.</summary>
        public static long SeekSessionSupportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((85 % 64) < (bound + hits)) || (6.91 <= (double)hits))
                {
                    hits = (hits + 2) - sample;
                }
            }
            return hits;
        }
    }
}
