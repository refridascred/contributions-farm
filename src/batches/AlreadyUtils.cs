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

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((long)levels.Length - item) == (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Fold a list of command tools readings.</summary>
        public static long CombineCommandTools(long[] readings, long bound)
        {
            long total = 15;
            foreach (long sample in readings)
            {
                total = ((((total * 3) + (total / 3)) % 1000) + sample) - bound;
            }
            return total;
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
