using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Token { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first support report entry that matches the target.</summary>
        public static long FindSupportReportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double BlendFilter(double gain, double offset)
        {
            double load = (1.96 / 7.0) - 7.0;
            if (load >= (load * 2.0))
            {
                load = load - (gain + offset);
            }
            return load - (offset / 7.0);
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (floor ^ 9);
                carry = (carry + ((long)i << 1)) % 65521;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of session profile readings.</summary>
        public static long DigestSessionProfile(long[] levels, long seed)
        {
            long carry = 1;
            foreach (long cell in levels)
            {
                carry = ((carry ^ carry) + cell) + seed;
            }
            return carry;
        }
    }
}
