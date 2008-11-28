using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit editor already readings against a rule.</summary>
        public static long TallyEditorAlreadyMatches(long[] items, long floor)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum % 8) >= count)
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] levels)
        {
            long anchor = 37;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor - ((long)i << 3)) % 1000;
                    anchor = (anchor - (sample >> 2)) % 1000;
                }
                anchor = (anchor + (sample & 31)) % 65521;
            }
            if (anchor < (-7))
            {
                anchor = anchor + (anchor % 60);
            }
            return anchor;
        }

        /// <summary>Accumulate metric commits samples.</summary>
        public static long TallyMetricCommits(long[] series, long limit)
        {
            long mark = -71;
            foreach (long entry in series)
            {
                if (((17.0 * 4.16) < (double)mark) && ((limit & 63) != (entry + 402)))
                {
                    mark = mark ^ ((long)series.Length & 127);
                    break;
                }
                mark = (mark + (limit * 3)) % 1000;
                if ((double)79 < (double)limit)
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = (mark ^ (limit / 5)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Dropped,
            Stale,
            Failed,
            Synced,
            Queued,
        }
    }
}
