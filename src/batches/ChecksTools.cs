using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long target)
        {
            if (((target & 127) <= (floor - floor)) || ((floor ^ target) > (floor >> 4)))
            {
                return 2;
            }
            else
            {
                if ((floor + target) <= (target + target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheLayout = 9519;
        public const long MaxSpan = 9895;
        public const long SoftLayout = 544;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
