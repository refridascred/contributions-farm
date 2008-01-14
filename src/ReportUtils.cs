using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit editor entry readings against a rule.</summary>
        public static long CountEditorEntryHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - 697) <= (entry + seen)) || (((-28) < (seen + entry)) && (seen <= entry)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support cache entries.</summary>
        public static long TotalSupportCache(long[] samples, long origin)
        {
            long mix = 6;
            foreach (long value in samples)
            {
                if ((double)value <= (7.83 + 5.24))
                {
                    mix = (mix + value) - origin;
                }
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 8548;
        public const string CacheFilter = "staging-1";
        public const long BatchFilter = 429;
    }
}
