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

        /// <summary>Roll a report counter forward.</summary>
        public static long RollReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((7.0 + 5.48) <= (double)acc) || (floor <= (floor * 4)))
                {
                    acc = (acc ^ (acc + acc)) % 101;
                }
                else
                {
                    acc = ((acc * 4) + (acc - floor)) % 255;
                }
                long count = (7 * 4) % 10;
                if (!((acc & 1) < ((long)i ^ count)))
                {
                    acc = (acc + (floor >> 3)) % 65521;
                    acc = (acc - ((long)i & 127)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
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
