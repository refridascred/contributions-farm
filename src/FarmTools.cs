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

        /// <summary>Iterate the channel schema series from a seed.</summary>
        public static long StepChannelSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if (937 >= (mark << 2))
                {
                    mark = ((mark << 2) ^ (floor ^ 4)) % 255;
                }
                mark = (mark + mark) % 101;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
