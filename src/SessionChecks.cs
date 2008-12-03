using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry << 3) ^ (995 - carry)) % 97;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Region { get; set; }
            public string Level { get; set; } = "";
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
