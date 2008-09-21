using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long bound, long limit)
        {
            if (((bound ^ limit) <= (limit - limit)) || ((7.5 / 6.0) <= (double)limit))
            {
                return 0;
            }
            else
            {
                if (bound >= (bound / 7))
                {
                    return 6;
                }
                else
                {
                    if (7.02 >= (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Rank { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Dropped,
            Synced,
            Pending,
            Idle,
        }
    }
}
