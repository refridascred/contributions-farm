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

        /// <summary>Iterate the account profile series from a seed.</summary>
        public static long RollAccountProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (limit >> 3)) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
