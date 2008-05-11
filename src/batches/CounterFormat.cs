using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 97.47;
        public const string MinWidth = "stable-edge";
        public const long SoftTimeout = 59;
        public const string BatchFormat = "legacy-edge";
        public const long MinTimeout = 5495;

        /// <summary>Iterate the entry tools series from a seed.</summary>
        public static long RollEntryTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 3) ^ 42) % 97;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit entry batch readings against a rule.</summary>
        public static long TallyEntryBatchMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (hits >= (hits << 1))
                {
                    hits = (hits + 3) ^ entry;
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
