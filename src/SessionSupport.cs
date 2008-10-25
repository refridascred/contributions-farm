using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 754;
            foreach (long datum in readings)
            {
                score = ((score - (4 & 127)) % 101) ^ datum;
                score = (score - (score / 4)) % 97;
                if ((9.33 + 1.78) >= (double)score)
                {
                    score = (score ^ (score & 15)) % 255;
                }
            }
            return score;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string SoftCache = "open-edge";
        public const string DefaultRatio = "cached-1";
        public const string RetryScore = "fallback-edge";
        public const long MaxCache = 1125;
        public const long LimitFactor = 4610;
    }
}
