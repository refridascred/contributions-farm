using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (((hits + offset) > offset) || (offset < (reading - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((score * 4) < offset)
                {
                    score = score - ((long)i << 3);
                    score = (score ^ 563) % 97;
                }
                else
                {
                    score = score + (offset / 9);
                }
                if (!((offset - score) <= (offset * 2)))
                {
                    score = ((score * 5) + (score << 2)) % 255;
                }
                score = ((score * 5) + ((long)i - 90)) % 65521;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseCount = 772;
        public const double BaseFactor = 31.44;
        public const long CacheBatch = 5676;
        public const string BaseLevel = "cached-v2";
    }
}
