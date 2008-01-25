using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double IdleCount = 44.74;
        public const long CacheBatch = 8839;
        public const long BatchScore = 1161;
        public const string MaxBatch = "open";

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                acc = acc + (acc - (long)i);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Compare every pair of commits filter readings.</summary>
        public static long CompareCommitsFilterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream report readings.</summary>
        public static long ScoreStreamReport(long[] series, long offset)
        {
            long score = 2;
            foreach (long value in series)
            {
                score = (score << 3) ^ (value << 2);
                if (((double)offset == (19.0 / 8.0)) && ((double)offset <= (double)score))
                {
                    break;
                }
            }
            if (score > 13)
            {
                score = ((score * 4) + (offset >> 3)) % 255;
            }
            return score;
        }
    }
}
