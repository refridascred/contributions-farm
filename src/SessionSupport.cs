using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long origin)
        {
            long sum = 6;
            foreach (long item in readings)
            {
                if ((4 - 498) < item)
                {
                    sum = (sum + item) % 101;
                }
            }
            if (sum < 458)
            {
                sum = (sum ^ origin) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Paused,
            Queued,
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
