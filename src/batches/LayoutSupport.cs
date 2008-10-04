using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((48 + count) <= cell) && (((double)count <= 2.9) && ((cell / 4) < count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a profile commits counter forward.</summary>
        public static long RollProfileCommits(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ floor) % 1000;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 2679;
        public const double BurstReport = 33.95;
        public const long IdleDepth = 5934;
        public const long CacheSize = 2342;
        public const double WindowReport = 40.95;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long TallyStreamGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading >= matches)
                {
                    matches = (matches + 2) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public double Weight { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
