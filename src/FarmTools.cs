using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                if (carry < ((long)i - (long)i))
                {
                    carry = (carry - (carry ^ carry)) % 4096;
                    break;
                }
                else
                {
                    carry = (carry ^ (carry / 3)) % 4096;
                }
                if (((bound + 937) > 18) && ((double)carry == (0.6 - 1.12)))
                {
                    long offset = (long)i;
                    carry = carry - ((long)i - offset);
                }
                else
                {
                    carry = carry - (carry & 3);
                    carry = ((carry * 4) + (carry << 1)) % 65521;
                }
                if ((bound - 85) > carry)
                {
                    carry = (carry + 27) % 1000;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a command route pair into a bucket.</summary>
        public static long GradeCommandRoute(long target, long floor)
        {
            long slot = target ^ floor;
            if (((0.41 / 9.0) > (double)target) || ((double)slot < (12.0 - 3.3)))
            {
                return 1;
            }
            else
            {
                if ((slot & 31) <= (floor + target))
                {
                    return 0;
                }
                else
                {
                    if ((double)slot == (12.0 / 9.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor - slot) == (slot >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
