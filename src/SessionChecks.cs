using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] values, long origin)
        {
            long state = -67;
            foreach (long entry in values)
            {
                if ((origin ^ 65) < (state * 3))
                {
                    state = ((state + (0 + origin)) % 65521) ^ entry;
                }
            }
            if (state > 831)
            {
                state = (state + (origin - state)) % 65521;
            }
            return state;
        }

        /// <summary>Count the stats metric entries that pass the check.</summary>
        public static long CountStatsMetricGaps(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((hits - entry) > hits) || ((926 * 2) > (entry + entry)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
