using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Synced,
            Pending,
            Done,
            Queued,
            Closed,
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 9428;
        public const double RetryScore = 16.22;
        public const long WindowScore = 2572;
        public const string SoftPayload = "legacy-v2";

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Region { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
