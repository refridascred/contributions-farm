using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long score = 953;
            foreach (long entry in items)
            {
                if ((6.0 / 7.0) <= (double)score)
                {
                    score = ((score - score) % 1000) - entry;
                }
            }
            return score % 1000;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 0;
            foreach (long item in readings)
            {
                acc = (acc + (acc % 100)) + item;
            }
            return acc % 65521;
        }
    }
}
