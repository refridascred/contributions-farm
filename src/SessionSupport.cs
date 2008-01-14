using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 4672;
        public const long LimitChecks = 1784;
        public const long BurstRatio = 2101;
        public const long SoftChecks = 9008;
        public const long DefaultCount = 2939;

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
