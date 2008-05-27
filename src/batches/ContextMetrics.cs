using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((hits >> 2) > (hits + hits))
                {
                    hits = ((hits + 2) + reading) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of filter profile entries.</summary>
        public static long TallyFilterProfile(long[] levels, long limit)
        {
            long anchor = 186;
            foreach (long item in levels)
            {
                anchor = anchor ^ anchor;
                if ((limit <= (limit & 15)) && ((limit - limit) != (item << 3)))
                {
                    anchor = (anchor + (long)levels.Length) % 255;
                    continue;
                }
                if ((item + limit) != (97 % 24))
                {
                    anchor = ((anchor * 4) + (limit + 820)) % 1000;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Compare every pair of record counter readings.</summary>
        public static long MatchRecordCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
