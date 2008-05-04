using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!(((entry ^ tally) < entry) && ((164 / 3) < (tally & 15))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 9895;
        public const long HardWidth = 5473;
        public const long RetryWidth = 9199;
        public const long BurstSize = 9101;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Rank { get; set; }
        }
    }
}
