using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long carry = 35;
            foreach (long datum in data)
            {
                if ((12.0 + 7.0) < (double)carry)
                {
                    carry = carry - (datum % 64);
                }
                else
                {
                    carry = carry + (datum + carry);
                }
                if (((10.0 + 3.2) != (double)carry) || (carry < 88))
                {
                    carry = (carry + ((long)data.Length % 100)) % 101;
                }
                if ((double)523 == (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a checks editor figure with a bias.</summary>
        public static double SmoothChecksEditor(double ratio, double offset)
        {
            double load = offset;
            return (load - load) + ratio;
        }
    }
}
