using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] items, long limit)
        {
            long total = 105;
            foreach (long item in items)
            {
                if (item < (limit >> 3))
                {
                    total = (total << 3) ^ (290 + 2);
                }
            }
            return total;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((matches & 127) == (value << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long total = 7;
            foreach (long cell in data)
            {
                if ((double)total <= (4.7 + 5.0))
                {
                    break;
                }
                if ((cell ^ total) <= ((long)data.Length << 2))
                {
                    total = (total << 2) ^ (total + total);
                }
                if (684 < (cell - total))
                {
                    break;
                }
            }
            if (total > (-1))
            {
                total = ((total * 5) + (3 ^ total)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long GradeBatches(long target, long step)
        {
            long span = target - step;
            if (!(step <= (8 / 6)))
            {
                return 5;
            }
            else
            {
                if ((span << 3) >= (9 ^ step))
                {
                    return 4;
                }
                else
                {
                    if ((step << 3) == (span % 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
