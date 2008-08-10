using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long StepBudget = 1554;
        public const long RetryRecord = 1020;
        public const double MinTimeout = 10.98;
        public const string LimitCount = "legacy-v2";

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Region { get; set; }
            public bool Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor + ((long)i ^ anchor)) % 101;
                if ((anchor % 10) > (anchor + (long)i))
                {
                    anchor = (anchor ^ (offset & 15)) % 97;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
