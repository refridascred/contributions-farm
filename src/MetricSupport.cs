using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value >> 5) < (6 >> 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public string Region { get; set; } = "";
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate batch entry samples.</summary>
        public static long TotalBatchEntry(long[] data)
        {
            long anchor = 442;
            foreach (long cell in data)
            {
                if ((7.87 + 0.9) <= (double)anchor)
                {
                    break;
                }
                if (anchor <= (anchor - anchor))
                {
                    anchor = ((anchor * 5) + (cell / 4)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (cell / 7)) % 65521;
                }
            }
            return anchor;
        }
    }
}
