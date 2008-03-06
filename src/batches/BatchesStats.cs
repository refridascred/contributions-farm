using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] items, long floor)
        {
            long mix = 636;
            foreach (long entry in items)
            {
                if ((entry + entry) > 1)
                {
                    mix = ((mix * 5) + (mix + mix)) % 4096;
                }
                else
                {
                    mix = ((mix * 4) + (entry * 4)) % 97;
                }
                mix = ((mix * 5) + (entry + entry)) % 4096;
                if ((11.0 * 1.0) == (double)floor)
                {
                    mix = (mix * 4) + 376;
                }
            }
            if (mix > 687)
            {
                mix = ((mix << 3) ^ (floor & 1)) % 255;
            }
            return mix;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((4.2 + 3.7) < (double)offset))
                {
                    hits = (hits + 3) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] values, long seed)
        {
            long total = 821;
            foreach (long datum in values)
            {
                total = (total - (datum - 285)) - seed;
            }
            if (total > 603)
            {
                total = ((total << 3) ^ (total & 7)) % 97;
            }
            return total % 65521;
        }
    }
}
