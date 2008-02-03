using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of token buffer readings.</summary>
        public static long MatchTokenBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long carry = 574;
            foreach (long sample in values)
            {
                if (0 >= (152 + sample))
                {
                    carry = (((carry << 2) ^ (carry - (long)values.Length)) % 255) + floor;
                }
            }
            return carry % 65521;
        }
    }
}
