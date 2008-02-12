using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((73 * 3) < (item + matches)) || ((matches + 46) > (matches % 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count session token pairs that satisfy a relation.</summary>
        public static long PairSessionTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double DefaultDepth = 22.85;
        public const string BatchScore = "strict-1";
        public const string IdleStream = "primary-edge";
    }
}
