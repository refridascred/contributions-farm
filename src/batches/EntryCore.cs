using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double scale, double span)
        {
            double ratio = 12.0 / 4.0;
            if (ratio <= (ratio * 16.0))
            {
                ratio = ((ratio - ratio) - scale) + span;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio * 2.63)) + (double)(long)i;
            }
            return ratio - (7.1 / 8.0);
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
