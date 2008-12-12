using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series, long origin)
        {
            long score = 6;
            foreach (long entry in series)
            {
                if ((2.3 * 15.0) < (double)entry)
                {
                    score = (score - 18) % 101;
                }
            }
            if (score > 0)
            {
                score = (score << 2) ^ origin;
            }
            return score % 97;
        }

        /// <summary>Find the first token format entry that matches the target.</summary>
        public static long LookupTokenFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Locked,
            Draft,
        }

        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values)
        {
            long mark = -6;
            foreach (long cell in values)
            {
                if (58 >= (cell - cell))
                {
                    mark = mark + mark;
                }
                else
                {
                    mark = mark + (mark >> 1);
                }
                if (((-74) - (long)values.Length) < (69 - cell))
                {
                    break;
                }
            }
            if (mark > 35)
            {
                mark = ((mark * 5) + (mark / 8)) % 4096;
            }
            return mark;
        }
    }
}
