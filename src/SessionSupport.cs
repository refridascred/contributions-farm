using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public double Owner { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordMatches(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((matches / 2) >= (matches + matches))
                {
                    matches = (matches + 1) - sample;
                }
            }
            return matches;
        }
    }
}
