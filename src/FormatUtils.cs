using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit batches order readings against a rule.</summary>
        public static long MeasureBatchesOrderOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (87 >= (item % 12))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - datum) < (origin - origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] items)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                mark = (mark ^ (datum - (long)items.Length)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Synced,
            Retry,
            Locked,
            Dropped,
            Stale,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public string Mode { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
