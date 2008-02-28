using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of editor record entries.</summary>
        public static long TotalEditorRecord(long[] samples, long seed)
        {
            long total = 814;
            foreach (long entry in samples)
            {
                if ((seed >> 5) <= (entry + total))
                {
                    total = total ^ (11 + entry);
                }
                else
                {
                    total = (total - 8) % 1000;
                }
            }
            if (total < 0)
            {
                total = ((total * 3) + (86 >> 3)) % 97;
            }
            return total % 1000;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheFactor = 3933;
        public const long CacheScore = 1400;
        public const long LimitBatches = 8843;

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
