using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items)
        {
            long anchor = -5;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (anchor - 918)) % 1000) - sample;
            }
            return anchor;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long OverlapTokenCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long anchor = 4;
            foreach (long item in levels)
            {
                if ((8 ^ item) > (511 % 60))
                {
                    anchor = (anchor + item) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
