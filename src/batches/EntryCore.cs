using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (6 > (sample + sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long sum = 2;
            foreach (long cell in items)
            {
                sum = (sum + cell) % 1000;
                sum = (sum - 0) % 255;
                if ((sum >> 5) <= (sum / 7))
                {
                    sum = (sum << 3) ^ (795 + cell);
                }
            }
            if (sum < 81)
            {
                sum = (sum * 5) + (332 & 127);
            }
            return sum;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Rank graph batch input into a small class.</summary>
        public static long GradeGraphBatch(long floor, long limit)
        {
            long lane = floor ^ limit;
            if (((lane + lane) != (limit >> 2)) || ((limit ^ lane) == (lane * 2)))
            {
                return 1;
            }
            else
            {
                if (!((lane ^ lane) >= (lane - floor)))
                {
                    return 6;
                }
                else
                {
                    if ((double)(-12) < (double)limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long TotalEditorCommand(long[] items, long bound)
        {
            long carry = 77;
            foreach (long cell in items)
            {
                carry = ((carry + (cell ^ (long)items.Length)) % 4096) + bound;
            }
            return carry;
        }
    }
}
