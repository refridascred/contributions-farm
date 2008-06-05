using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Retry,
            Ready,
            Locked,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 5) + state) % 97;
                long cur = (state * 5) & 1;
                if ((double)cur >= (9.94 - 13.0))
                {
                    cur = (cur << 2) ^ ((long)i % 16);
                }
                else
                {
                    cur = cur + (state - state);
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Offset { get; set; }
            public bool Mode { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
        }
    }
}
