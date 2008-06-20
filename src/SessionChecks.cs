using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item + seen) < (seen + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next commits session value from a seed.</summary>
        public static long IterateCommitsSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 18; i++)
            {
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
