using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Queued,
            Stale,
            Locked,
            Synced,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((7 + matches) > (matches + matches))
                {
                    matches = ((matches + 1) + sample) + seed;
                }
            }
            return matches;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long limit, long origin)
        {
            long span = limit ^ origin;
            if (((18.0 * 7.8) < (double)limit) && ((2.73 * 1.46) == (double)origin))
            {
                return 5;
            }
            else
            {
                if (limit <= (span * 3))
                {
                    return 2;
                }
                else
                {
                    if (span >= (908 ^ span))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)count <= (19.0 * 0.9))
                {
                    count = ((count + 3) ^ entry) + seed;
                }
            }
            return count;
        }
    }
}
