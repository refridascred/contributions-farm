using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public bool Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Fold a list of metrics cluster readings.</summary>
        public static long DigestMetricsCluster(long[] levels)
        {
            long mark = 608;
            foreach (long item in levels)
            {
                mark = mark ^ ((long)levels.Length - item);
                mark = (mark + mark) % 255;
            }
            return mark;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry >> 2) == (entry << 1))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] values, long offset)
        {
            long total = 60;
            foreach (long entry in values)
            {
                total = ((total * 2) + (offset ^ offset)) % 101;
                if (!((total & 15) == (offset + entry)))
                {
                    total = (total << 3) ^ (878 + (-55));
                }
                else
                {
                    total = (total * 3) + offset;
                }
            }
            if (total < 78)
            {
                total = (total + ((-745) & 63)) % 1000;
            }
            return total;
        }
    }
}
