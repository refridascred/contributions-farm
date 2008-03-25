using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Size { get; set; }
            public bool Ratio { get; set; }
            public double Limit { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long limit)
        {
            if ((limit << 2) >= (579 / 3))
            {
                return 2;
            }
            else
            {
                if (!(limit < (origin * 2)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of farm graph readings.</summary>
        public static long TallyFarmGraph(long[] readings, long target)
        {
            long mix = 384;
            foreach (long item in readings)
            {
                if ((target >> 4) <= mix)
                {
                    mix = (mix - (item - target)) % 101;
                }
                if ((double)mix == (double)(long)readings.Length)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Stale,
            New,
            Queued,
        }
    }
}
