using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] data, long target)
        {
            long anchor = -2;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            if (anchor < 51)
            {
                anchor = ((anchor * 4) + target) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of metrics queue entries.</summary>
        public static long CombineMetricsQueue(long[] values, long floor)
        {
            long mark = -77;
            foreach (long sample in values)
            {
                if ((14.0 / 5.0) <= (double)(long)values.Length)
                {
                    mark = (((mark + mark) % 255) - sample) - floor;
                }
                else
                {
                    mark = (mark - (mark * 5)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Closed,
            Draft,
            Queued,
        }
    }
}
