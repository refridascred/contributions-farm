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

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Ready,
            Retry,
            Pending,
        }

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
