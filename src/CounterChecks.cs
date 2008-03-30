using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Total { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter record samples are out of range.</summary>
        public static long AuditFilterRecordGaps(long[] items, long floor)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (entry > (floor + 6))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
