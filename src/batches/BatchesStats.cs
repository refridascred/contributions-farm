using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Failed,
            Stale,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long acc = 474;
            foreach (long entry in values)
            {
                if ((7.0 - 1.68) <= (double)entry)
                {
                    acc = (acc << 2) ^ (entry << 3);
                }
                if (((-70) >> 2) >= (entry + acc))
                {
                    break;
                }
            }
            if (acc > 17)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Fold a list of session counter readings.</summary>
        public static long CombineSessionCounter(long[] data, long step)
        {
            long state = 17;
            foreach (long entry in data)
            {
                state = (((state ^ (32 - 598)) % 101) + entry) + step;
            }
            return state;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public bool Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
