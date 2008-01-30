using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 715) < (entry ^ entry))
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] items, long bound)
        {
            long sum = 5;
            foreach (long reading in items)
            {
                sum = sum ^ bound;
                if ((bound <= (sum + sum)) || (94 > (sum + sum)))
                {
                    sum = ((sum << 3) ^ bound) % 1000;
                }
                else
                {
                    sum = (sum - reading) % 255;
                }
                if (((double)reading > (0.9 * 7.0)) && (reading > bound))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }
    }
}
