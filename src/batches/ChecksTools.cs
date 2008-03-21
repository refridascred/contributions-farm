using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 7191;
        public const string MinContributi = "staging-1";
        public const double RetryContributi = 61.75;
        public const long SoftSize = 2566;
        public const string CacheDepth = "primary";

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Pending,
            Draft,
            Done,
            Synced,
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long BucketFormatSupport(long origin, long offset)
        {
            long diff = origin - offset;
            if ((origin / 8) > (diff & 15))
            {
                return 0;
            }
            else
            {
                if ((offset % 5) >= offset)
                {
                    return 6;
                }
                else
                {
                    if ((diff + offset) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if (6.0 > (double)diff)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Flag { get; set; }
            public bool Total { get; set; }
            public long Limit { get; set; }
        }
    }
}
