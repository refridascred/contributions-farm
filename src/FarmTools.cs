using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Synced,
            Draft,
            Retry,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Weight { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Count the token account entries that pass the check.</summary>
        public static long TallyTokenAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (tally > (tally + entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
