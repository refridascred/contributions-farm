using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit format cache readings against a rule.</summary>
        public static long AuditFormatCacheMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((79 + 554) > hits)
                {
                    hits = ((hits + 2) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
