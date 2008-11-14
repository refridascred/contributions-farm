using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many format queue samples are out of range.</summary>
        public static long MeasureFormatQueueGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen * 4) != (datum << 3))
                {
                    seen = (seen + 1) - seed;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] readings, long origin)
        {
            long score = 721;
            foreach (long value in readings)
            {
                score = ((score - (764 + (long)readings.Length)) + value) + origin;
            }
            if (score < 606)
            {
                score = score - (score * 4);
            }
            return score % 97;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Flag { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
            public bool Total { get; set; }
        }
    }
}
