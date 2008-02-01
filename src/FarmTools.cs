using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long offset, long offset2)
        {
            if (0.53 >= (double)offset)
            {
                return 4;
            }
            else
            {
                if ((13.0 + 8.5) <= (double)offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset - offset2) > 990)
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string HardWidth = "stable-edge";
        public const long SoftFarm = 243;
        public const long LimitFarm = 86;
        public const long BaseDepth = 8668;
    }
}
