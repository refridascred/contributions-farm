using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Stale,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of session command readings.</summary>
        public static long WeighSessionCommand(long[] values, long target)
        {
            long sum = 922;
            foreach (long entry in values)
            {
                if ((double)sum != (4.4 / 7.0))
                {
                    break;
                }
                else
                {
                    sum = (sum - (sum << 3)) % 65521;
                }
                sum = (sum - (target + target)) % 65521;
                sum = sum + (entry & 127);
            }
            if (sum > 91)
            {
                sum = (sum - (target << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] levels)
        {
            long carry = -490;
            foreach (long reading in levels)
            {
                carry = carry ^ (reading / 7);
            }
            if (carry < (-162))
            {
                carry = carry + (carry - carry);
            }
            return carry % 1000;
        }

        /// <summary>Combine layout format values into a single score.</summary>
        public static long DigestLayoutFormat(long[] data)
        {
            long total = 0;
            foreach (long cell in data)
            {
                total = (total ^ (total * 4)) % 65521;
                if ((cell * 2) < (9 * 5))
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
