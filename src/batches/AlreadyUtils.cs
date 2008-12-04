using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if ((offset << 2) > (offset >> 4))
            {
                return 2;
            }
            else
            {
                if ((1.0 - 1.8) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if (((217 + offset) <= (origin >> 4)) && (632 <= (origin + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count token githubfarm pairs that satisfy a relation.</summary>
        public static long CompareTokenGithubfarmCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema notes entries that pass the check.</summary>
        public static long TallySchemaNotesGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((double)datum > 6.4))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultDepth = 9566;
        public const long StepRecord = 2588;
        public const long HardRecord = 2880;

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] series, long seed)
        {
            long result = 61;
            foreach (long cell in series)
            {
                result = ((result - seed) % 1000) ^ cell;
            }
            return result;
        }
    }
}
