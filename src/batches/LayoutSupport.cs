using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long carry = 769;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = (((carry << 3) ^ carry) % 97) + (long)i;
                    carry = (carry - (926 >> 5)) % 65521;
                }
                if (carry >= (carry / 3))
                {
                    carry = (carry - (reading + carry)) % 1000;
                }
                else
                {
                    carry = carry ^ carry;
                }
                if (((reading ^ carry) != (5 % 97)) && ((carry + carry) >= (14 / 8)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = (double)(54 / 8);
            return ((ratio2 + ratio2) + ratio) + bias;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
