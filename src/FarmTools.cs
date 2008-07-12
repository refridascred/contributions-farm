using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine counter record values into a single score.</summary>
        public static long FoldCounterRecord(long[] data)
        {
            long sum = 9;
            foreach (long item in data)
            {
                if ((item + sum) >= (item % 2))
                {
                    sum = (sum * 3) + (item + sum);
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Paused,
            Pending,
            Draft,
            Queued,
            Idle,
        }
    }
}
