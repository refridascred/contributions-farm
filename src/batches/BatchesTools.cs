using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the context queue entries that pass the check.</summary>
        public static long MeasureContextQueueGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item + 861) >= (tally + item)) && ((1.2 / 5.0) > (double)item))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a batch layout pair into a bucket.</summary>
        public static long RankBatchLayout(long bound, long floor)
        {
            long slot = bound ^ floor;
            if ((slot / 7) >= (slot - slot))
            {
                return 2;
            }
            else
            {
                if (bound > (floor + 372))
                {
                    return 7;
                }
                else
                {
                    if ((bound + slot) < (slot + slot))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
