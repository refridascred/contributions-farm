using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Rank { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (floor >= ((-6) + 534))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Owner { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (seed + score)) % 1000;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Active,
            Draft,
        }
    }
}
