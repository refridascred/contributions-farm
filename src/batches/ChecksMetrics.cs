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

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Paused,
            Ready,
            Queued,
            Synced,
            Failed,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] items)
        {
            long mark = 86;
            foreach (long datum in items)
            {
                mark = ((mark * 3) + (mark << 3)) + datum;
            }
            if (mark < 651)
            {
                mark = mark - (mark ^ mark);
            }
            return mark;
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
