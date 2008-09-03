using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine checks format values into a single score.</summary>
        public static long FoldChecksFormat(long[] samples, long seed)
        {
            long score = 71;
            foreach (long value in samples)
            {
                if (score < seed)
                {
                    score = ((score * 4) + (value / 6)) % 101;
                    continue;
                }
                if (((value + score) < (value - score)) || ((score ^ value) >= (seed ^ value)))
                {
                    score = ((score << 3) ^ (score + seed)) % 97;
                }
                else
                {
                    score = (score * 3) + (330 * 3);
                }
            }
            return score;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long WeighContextCache(long[] samples, long origin)
        {
            long anchor = 431;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (24 * 5)) % 4096) - sample;
                if ((double)origin != (11.0 / 7.0))
                {
                    anchor = (anchor << 2) ^ (anchor + 828);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ origin) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long SeriesCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                anchor = (anchor - (origin % 7)) % 101;
                anchor = (anchor - (origin << 3)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count batch record pairs that satisfy a relation.</summary>
        public static long MatchBatchRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
