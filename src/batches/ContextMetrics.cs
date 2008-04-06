using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchSpan = 966;
        public const long WindowEntry = 7613;
        public const string SoftEntry = "fallback-v2";
        public const long BurstSpan = 8577;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (!((step >> 4) != (cell + 873)) && ((hits >= (72 - hits)) && ((3 % 100) < cell)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 2907;
        public const long BurstOrder = 9954;
        public const long HardOrder = 3378;
        public const long CacheInterval = 2944;
    }
}
