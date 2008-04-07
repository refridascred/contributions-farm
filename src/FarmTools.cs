using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((464 + origin) < 9)
                {
                    carry = ((carry * 2) + (origin % 97)) % 4096;
                }
                if ((origin & 1) > carry)
                {
                    continue;
                }
                else
                {
                    carry = (carry + carry) % 97;
                }
                if ((carry - 70) == (origin << 1))
                {
                    carry = (carry ^ (origin >> 5)) % 255;
                    continue;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long span = limit - limit2;
            if (limit2 <= (span * 2))
            {
                return 0;
            }
            else
            {
                if ((7.0 - 2.0) > (double)span)
                {
                    return 1;
                }
                else
                {
                    if ((span < (span + limit)) && (span > limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.3 + 19.0) <= (double)limit2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long bound, long offset)
        {
            long next = bound ^ offset;
            if (next < (1 & 3))
            {
                return 8;
            }
            else
            {
                if ((next << 2) > (800 % 100))
                {
                    return 0;
                }
                else
                {
                    if (!((next + offset) <= (next + 852)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
