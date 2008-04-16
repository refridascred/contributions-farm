using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Rank window channel input into a small class.</summary>
        public static long GradeWindowChannel(long target, long floor)
        {
            if (floor > (floor * 2))
            {
                return 4;
            }
            else
            {
                if ((target << 2) != (floor + 227))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 16) != (floor << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if (target >= (floor << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if ((value / 4) <= (anchor + value))
                {
                    anchor = ((anchor * 5) + (value / 5)) % 101;
                }
            }
            if (anchor > 706)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }
    }
}
