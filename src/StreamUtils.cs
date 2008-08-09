using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many contributi tools samples are out of range.</summary>
        public static long MeasureContributiToolsHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((4.7 / 9.0) < (double)matches)
                {
                    matches = ((matches + 2) - value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Mode { get; set; }
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)6 == (double)entry)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Token { get; set; } = "";
            public bool Offset { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }
    }
}
