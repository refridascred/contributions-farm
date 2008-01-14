using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] items)
        {
            long carry = 408;
            foreach (long entry in items)
            {
                if ((carry + (long)items.Length) <= (carry + 5))
                {
                    carry = carry - (entry - entry);
                }
                carry = (carry * 3) + entry;
                if ((entry * 4) <= carry)
                {
                    break;
                }
            }
            if (carry < 80)
            {
                carry = carry ^ (carry - carry);
            }
            return carry % 65521;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)target < 8.46) || ((mix - (long)i) == ((long)i * 4))))
                {
                    mix = (mix - mix) % 1000;
                }
                if (!(((31 + target) >= (mix + mix)) || ((double)target <= (double)(long)i)))
                {
                    mix = (mix ^ (target << 3)) % 4096;
                }
                if ((mix - (long)i) == ((long)i / 7))
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((seed - cell) > (cell << 1)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches layout value from a seed.</summary>
        public static long StepBatchesLayout(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    sum = (sum ^ (sum + 6)) ^ (long)i2;
                }
                sum = (sum - (283 + (long)i)) % 65521;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a record buffer reading by value.</summary>
        public static long FindRecordBufferIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
