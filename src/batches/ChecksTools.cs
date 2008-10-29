using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long bound)
        {
            if (((-387) + 37) < (floor * 4))
            {
                return 0;
            }
            else
            {
                if (bound > floor)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
