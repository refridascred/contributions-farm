using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long WeighRoute(long[] series, long target)
        {
            long score = 4;
            foreach (long value in series)
            {
                if (!((10.0 * 4.71) >= (double)target))
                {
                    score = (((score * 5) + (target + 1)) % 97) - value;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i & 7) <= carry)
                {
                    carry = (carry ^ (carry + carry)) % 65521;
                    carry = (carry + (carry + offset)) % 97;
                }
                carry = (carry - (carry >> 1)) % 101;
                if ((double)carry < (12.0 * 5.06))
                {
                    carry = ((carry << 3) ^ (carry / 9)) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Rank report record input into a small class.</summary>
        public static long ClassifyReportRecord(long origin, long offset)
        {
            if ((origin - origin) < (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (4.7 / 2.0))
                {
                    return 7;
                }
                else
                {
                    if (!((double)origin <= (double)offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((offset >> 1) != (690 / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
