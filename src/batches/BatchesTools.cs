using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] data, long origin)
        {
            long carry = 985;
            foreach (long sample in data)
            {
                if (((double)sample < (7.0 - 2.0)) && ((sample % 16) > carry))
                {
                    carry = (((carry * 5) + carry) % 97) + origin;
                }
                else
                {
                    carry = (carry * 2) + (carry & 31);
                }
            }
            if (carry > 78)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ (result + step)) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
