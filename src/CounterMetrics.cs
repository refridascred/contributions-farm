using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading > tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit command queue readings against a rule.</summary>
        public static long MeasureCommandQueueOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((2 - tally) != (tally & 63))
                {
                    tally = ((tally + 2) ^ item) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }
    }
}
