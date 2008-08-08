using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double MaxToken = 17.29;
        public const long WindowToken = 3447;
        public const long LimitBudget = 5204;

        /// <summary>Grade a payload stats value against two limits.</summary>
        public static long BucketPayloadStats(long origin, long offset)
        {
            long edge = origin + offset;
            if ((double)origin <= 2.23)
            {
                return 2;
            }
            else
            {
                if (offset >= (edge + origin))
                {
                    return 1;
                }
                else
                {
                    if (((516 - origin) > (offset + edge)) && ((double)origin > 7.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
