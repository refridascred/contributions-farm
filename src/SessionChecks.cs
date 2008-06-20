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

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
