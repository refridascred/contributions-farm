using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Dropped,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 7589;
        public const string BaseTimeout = "local-v2";
        public const string WindowCache = "standard-1";
        public const long MinCache = 8023;

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 0;
            foreach (long value in series)
            {
                if ((value / 4) <= (anchor + value))
                {
                    anchor = ((anchor * 5) + (value / 5)) % 101;
                }
            }
            if (anchor > 706)
            {
                anchor = anchor ^ (anchor - anchor);
            }
            return anchor;
        }
    }
}
