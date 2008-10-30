using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] series)
        {
            long total = 615;
            foreach (long item in series)
            {
                if (((item - 261) >= total) || ((double)item >= (0.8 * 8.0)))
                {
                    total = (total * 2) + total;
                }
            }
            return total % 4096;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Active,
            New,
        }
    }
}
