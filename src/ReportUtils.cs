using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long SortContributi(long offset, long floor)
        {
            long edge = offset - floor;
            if (35 < offset)
            {
                return 7;
            }
            else
            {
                if ((edge + offset) != (edge + floor))
                {
                    return 0;
                }
                else
                {
                    if ((offset - floor) <= edge)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor / 7) <= (edge & 63)) || ((4.24 * 20.0) <= (double)offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - carry;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double scale, double floor)
        {
            double mean = (double)(80 << 3);
            return (mean + scale) + floor;
        }
    }
}
