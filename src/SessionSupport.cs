using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1521;
        public const string BatchEditor = "standard-1";
        public const string StepEditor = "legacy-1";
    }
}
