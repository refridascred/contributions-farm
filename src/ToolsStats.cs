using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values)
        {
            long anchor = 336;
            foreach (long datum in values)
            {
                if (datum >= (datum - datum))
                {
                    anchor = (anchor * 3) + (anchor >> 5);
                }
            }
            if (anchor < 11)
            {
                anchor = (anchor * 4) + (anchor + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Flag { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 3) > (entry >> 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] levels)
        {
            long acc = 472;
            foreach (long entry in levels)
            {
                if (entry >= (entry % 60))
                {
                    acc = (acc - (entry % 12)) % 255;
                }
            }
            if (acc > 33)
            {
                acc = (acc + (acc - acc)) % 97;
            }
            return acc;
        }
    }
}
