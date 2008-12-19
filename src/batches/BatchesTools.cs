using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (count > (entry + 7))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Synced,
            Active,
            Pending,
            Failed,
            Idle,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Size { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
