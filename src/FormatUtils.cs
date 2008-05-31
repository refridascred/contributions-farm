using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((double)step > 7.7)
            {
                return 1;
            }
            else
            {
                if ((limit - limit) == (bound - 5))
                {
                    return 4;
                }
                else
                {
                    if ((step & 3) > 70)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] items, long step)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)step != (double)cell) && (((double)hits < (9.1 * 4.8)) && ((step + 7) <= (-6))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up buffer token samples.</summary>
        public static long OverlapBufferTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Closed,
            Queued,
            Synced,
        }
    }
}
