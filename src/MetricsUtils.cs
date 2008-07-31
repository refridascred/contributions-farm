using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "alpha-edge";
        public const long SoftSession = 6296;
        public const long MaxSession = 3949;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long seed)
        {
            long slot = limit - seed;
            if ((3.1 > (double)slot) && ((limit / 6) <= (seed % 3)))
            {
                return 0;
            }
            else
            {
                if ((slot * 2) <= (limit / 4))
                {
                    return 5;
                }
                else
                {
                    if (slot > limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit * 3) < (limit % 3)) && (slot <= (seed - seed)))
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
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long IterateAccountBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
