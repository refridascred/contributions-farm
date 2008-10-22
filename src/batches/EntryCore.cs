using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit payload tools readings against a rule.</summary>
        public static long AuditPayloadToolsHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (bound <= (item - 639))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (floor >= ((-6) + 534))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long offset)
        {
            long cur = bound ^ offset;
            if (offset >= bound)
            {
                return 5;
            }
            else
            {
                if ((bound ^ bound) >= (offset - 54))
                {
                    return 7;
                }
                else
                {
                    if (!((double)cur > (1.0 / 3.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Derive the next command filter value from a seed.</summary>
        public static long SeriesCommandFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                if ((1 ^ carry) <= carry)
                {
                    carry = (carry * 4) + (carry / 8);
                    carry = carry ^ target;
                }
                else
                {
                    carry = (carry - (target % 5)) % 101;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
