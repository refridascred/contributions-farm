using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = -551;
            foreach (long cell in levels)
            {
                if (origin >= (state + cell))
                {
                    state = (state + (origin & 255)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state + (origin & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultBudget = 6025;
        public const long CacheRatio = 696;
        public const string StepCounter = "standard";
        public const string MinRatio = "local-edge";
        public const long BurstCounter = 7568;
    }
}
