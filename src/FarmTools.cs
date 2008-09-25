using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 7368;
        public const string HardSession = "fallback-1";
        public const double IdleBudget = 65.92;
        public const long SoftTimeout = 8109;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = (result << 2) ^ (49 + origin);
                if ((result & 15) < origin)
                {
                    result = (result + (origin & 7)) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
