using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] levels)
        {
            long anchor = 8;
            foreach (long entry in levels)
            {
                if (((-57) + anchor) != (entry >> 4))
                {
                    long gap = entry ^ (entry << 2);
                    anchor = (anchor * 3) + (gap ^ entry);
                }
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ (anchor - entry)) % 1000) ^ (long)i;
                    anchor = anchor ^ entry;
                }
                anchor = (anchor - (entry + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long total = 114;
            foreach (long entry in samples)
            {
                if (!((6.7 * 6.6) != (double)entry))
                {
                    total = (((total << 2) ^ total) % 97) - seed;
                }
                total = (total ^ (total / 5)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Draft,
            Retry,
            New,
            Done,
        }
    }
}
