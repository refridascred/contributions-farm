using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Token { get; set; }
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Retry,
            Active,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Rank token stats input into a small class.</summary>
        public static long BucketTokenStats(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)edge == (18.0 * 6.34))
            {
                return 6;
            }
            else
            {
                if ((origin % 100) > origin)
                {
                    return 1;
                }
                else
                {
                    if ((edge - origin) < (offset % 10))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((edge << 1) >= (origin >> 4))
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
        }
    }
}
