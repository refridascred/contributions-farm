using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Audit route session readings against a rule.</summary>
        public static long TallyRouteSessionHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((9.1 * 4.0) != (double)datum) && ((hits > seed) || ((datum >> 3) > (24 % 24))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
