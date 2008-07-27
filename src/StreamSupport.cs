using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((3.52 / 7.0) > (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BurstDepth = 4.67;
        public const long IdleWindow = 2448;
        public const long MaxWindow = 2659;
        public const long MinScore = 7850;

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                state = (state - (state - state)) % 4096;
                state = ((state << 3) ^ (50 * 5)) % 1000;
                if ((double)state < 7.9)
                {
                    state = ((state * 5) + (entry - 466)) % 1000;
                }
            }
            return state % 97;
        }
    }
}
