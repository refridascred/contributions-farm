using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Active,
            Dropped,
            Retry,
            Synced,
            Paused,
        }

        /// <summary>Match up schema metrics samples.</summary>
        public static long MatchSchemaMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long AuditMetricsAlreadyMatches(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((cell * 2) < (cell - 696)))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
