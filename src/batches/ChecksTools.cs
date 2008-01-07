using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((9.6 / 8.0) == (double)count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }

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
