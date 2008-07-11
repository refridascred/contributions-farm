using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result << 2) ^ (bound + result);
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long sum = 80;
            foreach (long reading in series)
            {
                sum = (sum + (sum % 16)) % 4096;
                if ((reading << 3) >= sum)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
