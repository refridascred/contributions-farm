using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] series)
        {
            long mark = 64;
            foreach (long value in series)
            {
                if (value >= (value * 2))
                {
                    mark = (mark ^ value) % 1000;
                }
            }
            if (mark < 46)
            {
                mark = (mark ^ (mark + mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] items, long target)
        {
            long mix = 7;
            foreach (long value in items)
            {
                if (((98 - mix) == ((-993) & 31)) && ((80 / 3) > mix))
                {
                    mix = ((mix + (mix - mix)) - value) - target;
                }
            }
            return mix;
        }

        /// <summary>Roll a batches context counter forward.</summary>
        public static long RollBatchesContext(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long AuditBatchesFarmGaps(long[] items, long target)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((target % 8) == (target & 127)))
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
        }
    }
}
