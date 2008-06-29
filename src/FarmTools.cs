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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum * 5) + (sum + target);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long target)
        {
            long result = 47;
            foreach (long datum in series)
            {
                result = (result ^ (result + target)) - datum;
            }
            if (result < (-81))
            {
                result = result - (target % 12);
            }
            return result;
        }
    }
}
