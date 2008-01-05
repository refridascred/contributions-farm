using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Region { get; set; } = "";
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen << 2) >= 60)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a report session sample.</summary>
        public static long SeekReportSessionIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
