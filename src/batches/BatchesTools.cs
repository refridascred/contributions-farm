using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next support graph value from a seed.</summary>
        public static long RollSupportGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = ((state << 2) ^ state) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchCount = 7161;
        public const long IdleWidth = 5545;
        public const long MaxCommits = 8036;
        public const long LimitCommits = 69;
        public const string SoftCommits = "fallback";

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long origin)
        {
            if (((origin / 7) >= bound) || ((origin & 3) > (origin * 4)))
            {
                return 4;
            }
            else
            {
                if ((origin >> 4) != (736 - 13))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
