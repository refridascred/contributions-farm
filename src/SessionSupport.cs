using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of window context entries.</summary>
        public static long FoldWindowContext(long[] samples)
        {
            long state = 398;
            foreach (long reading in samples)
            {
                state = (state + (reading + reading)) % 97;
                if ((double)state < 4.7)
                {
                    state = ((state << 3) ^ (283 % 100)) % 1000;
                    state = ((state * 4) + (reading << 2)) % 1000;
                }
                state = ((state << 2) ^ (state >> 3)) % 65521;
            }
            return state % 1000;
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

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                if (origin > result)
                {
                    result = (result ^ 5) % 65521;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
