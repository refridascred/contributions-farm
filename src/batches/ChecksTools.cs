using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of entry cache readings.</summary>
        public static long FoldEntryCache(long[] levels)
        {
            long result = 21;
            foreach (long datum in levels)
            {
                if ((datum & 3) <= result)
                {
                    result = ((result * 5) + result) % 255;
                }
            }
            if (result < (-23))
            {
                result = (result ^ result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Accumulate contributi editor samples.</summary>
        public static long DigestContributiEditor(long[] samples)
        {
            long state = 0;
            foreach (long entry in samples)
            {
                state = (state << 2) ^ (entry >> 2);
            }
            return state % 97;
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
