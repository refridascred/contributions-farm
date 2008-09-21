using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a notes account pair into a bucket.</summary>
        public static long GradeNotesAccount(long offset, long target)
        {
            if ((offset % 100) > offset)
            {
                return 6;
            }
            else
            {
                if (((-390) >= (target << 2)) || ((target * 5) == (target + target)))
                {
                    return 2;
                }
                else
                {
                    if ((offset >> 1) >= offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)offset != (7.18 - 7.4)) && (offset >= (target % 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Active,
            Synced,
            Failed,
            Stale,
        }

        /// <summary>Count cache command pairs that satisfy a relation.</summary>
        public static long PairCacheCommandCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long carry = -5;
            foreach (long sample in values)
            {
                if ((sample >= (sample + step)) && (step <= (carry + sample)))
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 2)
            {
                carry = carry - carry;
            }
            return carry;
        }
    }
}
