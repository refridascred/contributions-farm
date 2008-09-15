using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((target <= (datum & 3)) && !((seen << 3) <= (target * 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            New,
            Draft,
            Queued,
            Stale,
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Rank { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the cache graph series from a seed.</summary>
        public static long RollCacheGraph(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark - mark) % 101;
                mark = ((mark << 2) ^ (origin - origin)) % 255;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Flag { get; set; } = "";
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((double)value == (17.0 - 1.5)) && ((2.1 + 1.5) <= (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
