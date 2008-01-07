using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 9294;
        public const string DefaultFormat = "local";
        public const long LimitFormat = 9875;
        public const long BaseSpan = 701;

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Token { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((3.8 + 2.47) > (double)seen)
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell / 6) <= matches)
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
