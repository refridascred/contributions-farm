using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate stream command samples.</summary>
        public static long CombineStreamCommand(long[] items, long offset)
        {
            long carry = 37;
            foreach (long item in items)
            {
                if ((offset + item) > 57)
                {
                    carry = carry - item;
                }
                else
                {
                    carry = carry + 4;
                }
            }
            return carry;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((((double)hits <= (2.0 * 3.6)) && ((value + hits) < (hits % 3))) && (hits <= (hits << 3)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value - 73) != (value + tally))
                {
                    tally = (tally + 3) + offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Score { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((reading ^ reading) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a layout window value against two limits.</summary>
        public static long ClassifyLayoutWindow(long offset, long step)
        {
            if (((double)offset < (9.66 - 3.33)) && (step < (offset ^ step)))
            {
                return 2;
            }
            else
            {
                if ((step + offset) >= (step ^ offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
