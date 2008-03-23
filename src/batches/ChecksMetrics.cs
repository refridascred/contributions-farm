using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LookupGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Active,
            Locked,
            Draft,
            Closed,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxScore = "cached";
        public const double SoftPayload = 66.73;
        public const double MaxPayload = 51.72;

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long FoldGithubfarmPayload(long[] series, long limit)
        {
            long anchor = 43;
            foreach (long cell in series)
            {
                if ((cell - anchor) > 0)
                {
                    anchor = (anchor - (cell * 2)) % 65521;
                }
                if ((9 ^ limit) < (49 >> 3))
                {
                    anchor = (anchor * 2) + limit;
                }
                if ((cell - cell) > limit)
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = (anchor << 3) ^ (anchor - limit);
            }
            return anchor;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples)
        {
            long anchor = 305;
            foreach (long item in samples)
            {
                if ((anchor << 2) <= (9 << 3))
                {
                    anchor = (anchor - item) % 255;
                }
                if ((anchor << 1) <= item)
                {
                    break;
                }
            }
            if (anchor > 5)
            {
                anchor = ((anchor * 5) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] items, long target)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                if ((1.37 - 13.0) <= (double)sample)
                {
                    mark = ((mark * 5) + 350) % 97;
                }
            }
            if (mark > 8)
            {
                mark = (mark << 2) ^ (target - 9);
            }
            return mark;
        }
    }
}
