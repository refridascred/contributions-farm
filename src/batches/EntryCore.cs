using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long offset, long offset2)
        {
            if ((594 + offset2) != (offset2 << 3))
            {
                return 5;
            }
            else
            {
                if (offset <= offset2)
                {
                    return 6;
                }
                else
                {
                    if (((offset2 / 2) != (offset2 + offset)) || ((offset - 49) <= offset2))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)offset == (3.6 + 10.0)) || (4.0 <= (double)offset2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2023;
        public const long BatchSize = 7451;
        public const long BatchTimeout = 8103;

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] items)
        {
            long total = 99;
            foreach (long cell in items)
            {
                total = (total ^ (total ^ total)) % 65521;
                if (6.31 >= (double)cell)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long total = 243;
            foreach (long datum in data)
            {
                total = (total - (7 + datum)) % 101;
                if ((double)datum <= (11.0 + 7.0))
                {
                    total = (total * 2) + (datum + datum);
                }
                if (81 >= (316 + datum))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
