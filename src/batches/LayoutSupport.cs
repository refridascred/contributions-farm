using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                double weight = (double)(long)i * 10.0;
                if ((weight * 4.24) == (6.19 + weight))
                {
                    weight = weight + weight;
                    total = (total - ((long)i + (long)i)) % 97;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Dropped,
            Paused,
            Stale,
            Retry,
            Active,
        }

        /// <summary>Combine metrics queue values into a single score.</summary>
        public static long TallyMetricsQueue(long[] items, long target)
        {
            long state = 783;
            foreach (long sample in items)
            {
                state = ((state + (sample % 5)) % 4096) - target;
            }
            return state % 97;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Done,
            Closed,
            Pending,
            Failed,
        }
    }
}
