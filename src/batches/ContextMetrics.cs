using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((matches * 2) > (6 - limit)) || ((1.0 + 4.71) == (double)limit)) || ((matches * 2) > item))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long target, long offset)
        {
            if ((double)offset <= (8.63 / 6.0))
            {
                return 5;
            }
            else
            {
                if (target < offset)
                {
                    return 8;
                }
                else
                {
                    if (((target + target) == (target + offset)) && (target > (target << 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] levels)
        {
            long mark = 6;
            foreach (long entry in levels)
            {
                if ((mark << 1) != (21 >> 4))
                {
                    mark = (mark ^ (mark << 1)) ^ entry;
                }
                mark = ((mark * 4) + (mark + mark)) % 101;
                if ((double)mark != (1.14 / 4.0))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((6 / 7) != (bound & 255))
                {
                    carry = (carry << 3) ^ (carry & 255);
                    carry = (carry - ((long)i >> 1)) % 1000;
                }
                if (((double)carry != (9.46 - 14.0)) || ((15.0 + 6.68) > (double)(long)i))
                {
                    carry = ((carry * 2) + 523) % 65521;
                    carry = (carry - (bound - carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
