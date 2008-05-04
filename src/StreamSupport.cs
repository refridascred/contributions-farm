using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate checks buffer readings against a bound.</summary>
        public static bool GuardChecksBufferBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Failed,
            Synced,
            Done,
        }
    }
}
