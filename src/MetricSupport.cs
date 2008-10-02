using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
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
