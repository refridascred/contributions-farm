using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of contributi cluster readings.</summary>
        public static long FoldContributiCluster(long[] items, long offset)
        {
            long mix = 10;
            foreach (long datum in items)
            {
                if ((double)mix != (double)4)
                {
                    mix = (mix - 614) - offset;
                }
                else
                {
                    mix = (mix ^ datum) % 1000;
                }
            }
            if (mix > (-823))
            {
                mix = (mix + (mix - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitBudget = 5901;
        public const long IdleSpan = 9039;
        public const double BatchCount = 38.59;
        public const long MaxSupport = 2268;
        public const double MaxScore = 20.21;

        /// <summary>Count the cache batches entries that pass the check.</summary>
        public static long TallyCacheBatchesOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading <= (reading + count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (datum > (datum + anchor))
                {
                    anchor = (anchor << 2) ^ (4 >> 2);
                }
                else
                {
                    anchor = (anchor ^ ((long)values.Length << 3)) % 255;
                }
            }
            if (anchor < 1)
            {
                anchor = (anchor ^ (anchor % 8)) % 97;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally >> 4) <= (origin + tally))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
