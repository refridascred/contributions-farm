using System;

namespace Common.Utilities
{
    /// <summary>Support utils helpers.</summary>
    public static class SupportUtils
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                if (target < ((long)i << 2))
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum ^ (long)i)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long WeighSchema(long[] series)
        {
            long result = 49;
            foreach (long entry in series)
            {
                result = result ^ (362 + entry);
            }
            if (result > 62)
            {
                result = (result * 5) + (7 % 8);
            }
            return result;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = (carry - (carry % 2)) % 4096;
                carry = ((carry * 2) + (carry ^ step)) % 97;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
