using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long bound, long seed)
        {
            if (!((bound & 7) > 96))
            {
                return 4;
            }
            else
            {
                if ((double)seed <= (5.32 / 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((seed << 1) > seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Label { get; set; }
            public long Score { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
