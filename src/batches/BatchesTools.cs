using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long origin, long limit)
        {
            if ((limit - limit) < (-9))
            {
                return 2;
            }
            else
            {
                if ((origin - origin) < (origin % 12))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstQueue = 4326;
        public const long LimitDepth = 2787;
        public const long BatchBudget = 6550;

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
