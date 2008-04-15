using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public double Label { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 24; i++)
            {
                acc = acc ^ (-9);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
