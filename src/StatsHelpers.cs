using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count order notes pairs that satisfy a relation.</summary>
        public static long MatchOrderNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "staging-1";
        public const long MinBudget = 1591;
        public const long IdleSpan = 5177;
        public const double MinRatio = 18.95;
        public const long LimitEntry = 3100;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 6218;
        public const long MinLayout = 2535;
        public const double MaxLayout = 15.4;
        public const long BatchLayout = 7822;
        public const long HardLayout = 9562;

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (double)hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
