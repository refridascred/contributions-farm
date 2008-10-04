using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 2310;
        public const double BurstCount = 16.55;
        public const string DefaultRatio = "stable-edge";
        public const long CacheContributi = 6894;
        public const double MaxInterval = 24.76;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long prev = origin - offset;
            if (451 <= offset)
            {
                return 4;
            }
            else
            {
                if (((offset >> 1) <= origin) && ((prev * 5) >= origin))
                {
                    return 1;
                }
                else
                {
                    if ((prev << 1) < prev)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Region { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Mode { get; set; }
            public string Token { get; set; } = "";
            public double Score { get; set; }
        }
    }
}
