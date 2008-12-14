using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchWidth = 59.71;
        public const long WindowCommits = 8104;
        public const string SoftRatio = "local-1";
        public const long MinCommits = 7803;

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Derive the next counter payload value from a seed.</summary>
        public static long DeriveCounterPayload(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + step) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Dropped,
            Synced,
            Active,
            New,
            Draft,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] series, long seed)
        {
            long mix = 69;
            foreach (long value in series)
            {
                if ((value - value) < mix)
                {
                    mix = ((mix << 3) ^ value) - seed;
                }
                else
                {
                    mix = (mix ^ mix) % 101;
                }
            }
            if (mix > 8)
            {
                mix = (mix ^ (mix + mix)) % 4096;
            }
            return mix % 4096;
        }
    }
}
