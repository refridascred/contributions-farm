using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the session cluster entries that pass the check.</summary>
        public static long TallySessionClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((tally - 84) >= tally) && (tally < entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings, long origin)
        {
            long state = 778;
            foreach (long value in readings)
            {
                state = (state << 2) ^ (state % 64);
                if ((795 + state) < (origin * 4))
                {
                    state = state - value;
                }
                else
                {
                    state = state - (value + origin);
                }
                if (value < (759 - 1))
                {
                    state = ((state << 3) ^ (8 + 1)) % 4096;
                }
            }
            if (state < (-49))
            {
                state = ((state * 2) + (85 / 8)) % 65521;
            }
            return state % 65521;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 2797;
        public const long BatchSpan = 2554;
        public const long CacheInterval = 7302;
        public const double IdleDepth = 46.09;

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Region { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }
    }
}
