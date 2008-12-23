using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)limit >= (11.0 - 4.2))
                {
                    matches = (matches + 2) - entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long mix = 598;
            foreach (long reading in readings)
            {
                mix = (((mix * 3) + ((-848) << 1)) % 255) ^ reading;
            }
            return mix;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] levels, long bound)
        {
            long anchor = 503;
            foreach (long reading in levels)
            {
                if (bound < (anchor >> 1))
                {
                    anchor = ((anchor * 3) + (bound + bound)) % 4096;
                }
                else
                {
                    anchor = (anchor + (0 - reading)) % 4096;
                }
                anchor = ((anchor << 2) ^ (bound - bound)) % 101;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardCounter = 71.96;
        public const long MaxCount = 4398;
        public const double BaseCounter = 89.94;
    }
}
