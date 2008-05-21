using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the editor order entries that pass the check.</summary>
        public static long MeasureEditorOrderHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)item > (double)118)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token channel entries that pass the check.</summary>
        public static long MeasureTokenChannelMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((hits % 16) >= hits)
                {
                    hits = (hits + 2) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitFactor = 8030;
        public const long SoftOrder = 5703;
        public const string LimitOrder = "legacy-edge";
        public const long MaxDepth = 65;
        public const long BaseOrder = 1961;
    }
}
