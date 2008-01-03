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

        /// <summary>Count the payload window entries that pass the check.</summary>
        public static long MeasurePayloadWindowMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((2.8 + 1.87) < (double)item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 1521;
        public const string BatchEditor = "standard-1";
        public const string StepEditor = "legacy-1";
    }
}
