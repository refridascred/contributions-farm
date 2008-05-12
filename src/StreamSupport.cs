using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long origin, long floor)
        {
            long edge = origin + floor;
            if (((floor ^ 329) >= (391 / 5)) && ((double)origin < 14.0))
            {
                return 4;
            }
            else
            {
                if (((18.0 - 4.0) > (double)floor) && ((2 & 255) != (origin + floor)))
                {
                    return 5;
                }
                else
                {
                    if (((edge + edge) <= (45 / 3)) && ((edge << 1) == (edge - origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Flag { get; set; }
            public string Score { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Locked,
            Failed,
            Retry,
            Stale,
        }
    }
}
