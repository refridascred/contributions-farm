using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxScore = 36.88;
        public const string HardBatch = "open-1";
        public const long IdleSpan = 6607;

        /// <summary>Count the session profile entries that pass the check.</summary>
        public static long CountSessionProfileMatches(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading != (5.0 - 16.0))
                {
                    matches = (matches + 1) + target;
                }
            }
            return matches;
        }
    }
}
