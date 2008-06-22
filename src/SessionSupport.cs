using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long RollContext(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = (total + ((long)i & 7)) % 65521;
                if (!((double)offset < (double)total))
                {
                    total = total + (8 + total);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                if ((step << 3) > total)
                {
                    total = (total + (2 & 1)) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total - (559 - 60)) % 97) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum - sum) % 255;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
