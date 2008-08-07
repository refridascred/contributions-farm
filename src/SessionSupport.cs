using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length <= (seen << 2)) || ((sample << 1) < (-416)))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)3 > (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
