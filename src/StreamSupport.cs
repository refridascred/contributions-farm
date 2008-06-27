using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of cache channel entries.</summary>
        public static long CombineCacheChannel(long[] readings, long target)
        {
            long acc = 4;
            foreach (long datum in readings)
            {
                if (((5.0 / 8.0) != (double)target) && ((double)target < (double)acc))
                {
                    acc = ((acc - ((long)readings.Length - target)) % 4096) - datum;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
        }
    }
}
