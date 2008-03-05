using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardScore = 4712;
        public const long MinCount = 6351;
        public const long BaseTimeout = 5330;
        public const long BatchSize = 1821;

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
