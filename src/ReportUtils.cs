using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(450 > (reading - (-2))))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((((-1) & 7) <= (24 + item)) && (item < (seed - count))) || ((9.3 - 5.0) >= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public double Rank { get; set; }
            public double Count { get; set; }
        }
    }
}
