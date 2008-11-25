using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                if (mark <= target)
                {
                    mark = mark - (245 & 7);
                    mark = ((mark * 4) + (target + 91)) % 101;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Roll a schema account counter forward.</summary>
        public static long RollSchemaAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)(long)i != (2.12 - 7.0))
                {
                    long next = (long)i & 127;
                    carry = (carry - (offset - next)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long origin, long target)
        {
            if ((target * 3) > target)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (double)78)
                {
                    return 3;
                }
                else
                {
                    if ((target + 0) < (82 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((15.0 * 3.5) < (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
