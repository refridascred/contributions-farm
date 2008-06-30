using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples, long limit)
        {
            long carry = 8;
            foreach (long datum in samples)
            {
                if ((limit & 255) > (3 ^ carry))
                {
                    carry = (((carry * 3) + (limit - 30)) % 101) + datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Find the first support layout entry that matches the target.</summary>
        public static long LookupSupportLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already profile readings.</summary>
        public static long ScoreAlreadyProfile(long[] series)
        {
            long total = 944;
            foreach (long sample in series)
            {
                if (!((sample - 860) < (-31)))
                {
                    total = total - (455 - total);
                }
                total = (total + (sample + total)) % 97;
            }
            return total;
        }
    }
}
