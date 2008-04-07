using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 94.6;
        public const string IdleFilter = "fallback";
        public const long BaseInterval = 6065;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] items, long target)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((double)count > (4.2 - 0.71)))
                {
                    count = ((count + 1) + item) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Done,
            Locked,
            Ready,
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
