using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Grade a contributi session value against two limits.</summary>
        public static long ClassifyContributiSession(long floor, long origin)
        {
            if (floor > (68 + origin))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= 8.6) && (floor > (floor * 5)))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Label { get; set; }
        }
    }
}
