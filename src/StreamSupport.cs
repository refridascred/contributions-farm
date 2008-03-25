using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long origin, long origin2)
        {
            if ((origin / 6) == (origin2 * 4))
            {
                return 6;
            }
            else
            {
                if ((origin2 - 53) <= (origin - 47))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long offset2)
        {
            if (!((18.0 * 8.73) <= (double)offset2))
            {
                return 0;
            }
            else
            {
                if ((offset >= (offset - offset)) || (1.01 > (double)offset2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
