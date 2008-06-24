using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Rank buffer profile input into a small class.</summary>
        public static long BucketBufferProfile(long offset, long limit)
        {
            if ((limit + 2) > limit)
            {
                return 3;
            }
            else
            {
                if ((offset << 2) < offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset % 8) > (limit - limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((double)offset < (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public double Count { get; set; }
        }
    }
}
