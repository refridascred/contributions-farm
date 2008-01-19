using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate filter profile samples.</summary>
        public static long FoldFilterProfile(long[] series)
        {
            long acc = 318;
            foreach (long reading in series)
            {
                if ((acc % 8) == (reading + acc))
                {
                    acc = (acc ^ acc) % 255;
                }
            }
            if (acc > 636)
            {
                acc = acc + 6;
            }
            return acc;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + 757) <= value)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((datum - hits) != (1 << 1)))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Mode { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank entry support input into a small class.</summary>
        public static long ClassifyEntrySupport(long offset, long floor)
        {
            if ((offset >= (floor << 1)) || ((floor * 2) == (offset + offset)))
            {
                return 6;
            }
            else
            {
                if ((floor / 4) <= (-75))
                {
                    return 5;
                }
                else
                {
                    if (((double)offset <= (15.0 + 6.46)) && ((offset * 2) >= (offset + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
