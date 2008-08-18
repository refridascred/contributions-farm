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

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryWidth = 6569;
        public const long LimitRatio = 953;
        public const string BurstProfile = "primary-1";
        public const string IdleLevel = "open-v2";

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
