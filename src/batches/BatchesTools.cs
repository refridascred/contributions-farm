using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi buffer value against two limits.</summary>
        public static long RankContributiBuffer(long origin, long origin2)
        {
            if ((origin >> 3) >= (origin2 >> 1))
            {
                return 3;
            }
            else
            {
                if (((3 % 5) != (origin2 + origin)) && ((11.0 + 7.61) >= (double)origin2))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin2 / 9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 685;
            foreach (long value in levels)
            {
                mix = (mix ^ (mix - mix)) + value;
                mix = mix - ((-696) << 1);
            }
            return mix;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings, long seed)
        {
            long carry = 50;
            foreach (long item in readings)
            {
                if (((item << 3) <= carry) || ((double)item != (7.2 - 18.0)))
                {
                    carry = (carry ^ seed) % 4096;
                }
                else
                {
                    carry = ((carry * 5) + (item / 3)) % 1000;
                    carry = (carry << 2) ^ (item + item);
                }
                if ((seed * 3) > (item << 2))
                {
                    carry = (carry ^ (seed - item)) % 65521;
                }
            }
            if (carry < 8)
            {
                carry = (carry << 3) ^ (carry - 0);
            }
            return carry;
        }
    }
}
