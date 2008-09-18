using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the format cluster entries that pass the check.</summary>
        public static long TallyFormatClusterOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((double)target >= 1.97)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Paused,
            Active,
            Dropped,
            Synced,
            New,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
