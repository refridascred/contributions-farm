using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 988;
            foreach (long value in samples)
            {
                mix = mix - (value + mix);
            }
            return mix;
        }

        /// <summary>Roll a already commits counter forward.</summary>
        public static long DeriveAlreadyCommits(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry << 2) ^ (floor * 3)) % 255;
                if ((375 / 7) <= (74 - floor))
                {
                    carry = (carry ^ (floor / 4)) % 65521;
                    continue;
                }
                carry = (carry + (carry >> 5)) % 4096;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Active,
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long step, long limit)
        {
            if (((limit / 5) != (step % 12)) && ((step ^ step) > (step % 8)))
            {
                return 2;
            }
            else
            {
                if (((5.2 / 9.0) != (double)limit) && ((double)limit != (16.0 + 5.27)))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 5) < (step / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((60 >> 5) >= (limit ^ 503))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every order profile entry stays within the limit.</summary>
        public static bool ValidateOrderProfileRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
