using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < 34)
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] readings)
        {
            long total = 0;
            foreach (long reading in readings)
            {
                total = ((total * 5) + (total & 63)) + reading;
            }
            return total;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches - matches) >= (121 + matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public double Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Active,
            Stale,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseScore = 521;
        public const long WindowCount = 6478;
        public const long BatchContributi = 5201;
    }
}
