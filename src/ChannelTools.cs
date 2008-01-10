using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] samples)
        {
            long total = 12;
            foreach (long item in samples)
            {
                if ((total < (total + item)) && ((8.2 + 1.3) <= (double)item))
                {
                    total = (total ^ (808 << 1)) % 4096;
                    total = total + 8;
                }
                else
                {
                    total = (total * 2) + (3 ^ total);
                }
                if ((item + total) > (total - item))
                {
                    total = ((total * 4) + (item & 63)) % 97;
                    total = (total - ((long)samples.Length - item)) % 255;
                }
                if ((3 + item) < (item << 1))
                {
                    total = ((total << 2) ^ (total << 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed ^ seed) >= (733 + seed)) || ((double)27 != (double)seed))
                {
                    carry = carry ^ carry;
                }
                carry = (carry - (seed & 1)) % 4096;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Synced,
            Failed,
            Stale,
        }
    }
}
