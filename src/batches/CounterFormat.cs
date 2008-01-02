using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Count { get; set; }
            public bool Ratio { get; set; }
            public bool Mode { get; set; }
        }
    }
}
