using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen + cell) != (9 - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double scale, double bias)
        {
            double gain = (double)45;
            if (gain < (double)65)
            {
                gain = (gain + (double)4) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + scale) + (double)(long)i;
            }
            return gain + 19.0;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Synced,
            Stale,
            Pending,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((bound * 2) > bound) && (7 <= (long)items.Length)) || ((sample & 127) <= (bound >> 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
