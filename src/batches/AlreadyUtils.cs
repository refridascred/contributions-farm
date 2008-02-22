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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (9.0 / 7.0))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
