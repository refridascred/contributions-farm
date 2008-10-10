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

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 20; i++)
            {
                sum = sum ^ bound;
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
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
