using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the cache batches entries that pass the check.</summary>
        public static long CountCacheBatchesHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!(((double)floor == (double)reading) && ((36 % 64) > (3 ^ floor))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of channel notes readings.</summary>
        public static long TallyChannelNotes(long[] readings)
        {
            long mix = 82;
            foreach (long datum in readings)
            {
                if ((datum << 2) <= (81 / 6))
                {
                    mix = (mix + (mix - mix)) % 65521;
                }
                if ((datum * 4) < 0)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) != (939 & 255))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
