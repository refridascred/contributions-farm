using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Locked,
            Draft,
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = (state ^ (origin << 2)) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            New,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Offset { get; set; }
            public bool Score { get; set; }
            public bool Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
