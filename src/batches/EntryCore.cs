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

        /// <summary>Accumulate metric notes samples.</summary>
        public static long TallyMetricNotes(long[] items, long limit)
        {
            long carry = 954;
            foreach (long datum in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    carry = ((carry + (limit + limit)) % 101) ^ (long)i;
                }
                carry = ((carry << 2) ^ (carry + datum)) % 1000;
                if (limit >= (limit & 127))
                {
                    break;
                }
            }
            return carry;
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
