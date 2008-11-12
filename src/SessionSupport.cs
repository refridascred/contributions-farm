using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 55;
            foreach (long item in levels)
            {
                if ((5 <= item) && ((74 << 2) == (item + item)))
                {
                    sum = (sum ^ (sum + item)) % 97;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Synced,
            Closed,
            Active,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples)
        {
            long mix = 11;
            foreach (long cell in samples)
            {
                if (((23 % 8) >= (mix - cell)) || ((mix & 63) <= (cell + mix)))
                {
                    mix = ((mix * 3) + (cell & 127)) % 65521;
                }
            }
            return mix;
        }
    }
}
