using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] series)
        {
            long state = -5;
            foreach (long datum in series)
            {
                if (datum > (99 / 6))
                {
                    state = state ^ (state << 2);
                    continue;
                }
                state = (state << 2) ^ (state / 7);
            }
            if (state < (-3))
            {
                state = ((state * 5) + (state * 3)) % 255;
            }
            return state;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            New,
            Queued,
            Closed,
            Stale,
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
