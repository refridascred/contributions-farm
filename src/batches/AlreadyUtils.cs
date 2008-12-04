using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a record commits counter forward.</summary>
        public static long DeriveRecordCommits(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((limit << 1) <= (limit + limit)))
                {
                    result = result ^ (limit % 8);
                    result = (result ^ limit) % 255;
                }
                result = ((result << 3) ^ (result * 4)) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
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
