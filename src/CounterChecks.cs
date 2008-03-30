using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long target, long floor)
        {
            if ((target + floor) == (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((target - floor) >= floor)
                {
                    return 4;
                }
                else
                {
                    if (floor >= (target >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 12;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = (total ^ (total % 24)) + (long)i;
                }
                total = total - (item & 127);
            }
            return total % 65521;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            New,
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long offset, long limit)
        {
            long slot = offset - limit;
            if (((-234) >= slot) && ((double)limit == (5.0 + 1.56)))
            {
                return 1;
            }
            else
            {
                if (!((double)slot == (double)773))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) > (offset << 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long step, long offset)
        {
            if ((offset - step) > step)
            {
                return 4;
            }
            else
            {
                if (15 > (step << 3))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
