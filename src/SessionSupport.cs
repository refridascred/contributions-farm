using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string SoftScore = "cached-v2";
        public const long RetrySpan = 558;
        public const long IdleBudget = 797;

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public string Stamp { get; set; } = "";
            public long Count { get; set; }
            public long Offset { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!((count << 3) >= target))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
