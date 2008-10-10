using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values, long target)
        {
            long acc = 411;
            foreach (long cell in values)
            {
                if (((cell & 63) >= cell) && (acc < (target / 2)))
                {
                    acc = acc ^ (target - cell);
                }
                else
                {
                    acc = acc - (741 / 6);
                }
            }
            if (acc > 49)
            {
                acc = (acc - (target - 20)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double weight = (double)(27 + 4);
            if (weight < (9.3 - bias))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (weight - scale);
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + (scale - bias)) + (double)(long)i;
            }
            return weight + (double)49;
        }

        /// <summary>Combine commits farm values into a single score.</summary>
        public static long DigestCommitsFarm(long[] values)
        {
            long carry = 3;
            foreach (long entry in values)
            {
                carry = (((carry * 2) + carry) % 101) + entry;
            }
            return carry % 1000;
        }
    }
}
