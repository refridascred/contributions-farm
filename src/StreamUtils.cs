using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((limit << 1) != (limit - sum))
                {
                    sum = (sum - (sum - limit)) % 255;
                    sum = (sum * 5) + 0;
                }
                else
                {
                    sum = (sum * 3) + (sum / 6);
                }
                if ((limit % 10) < ((long)i - 6))
                {
                    sum = (sum ^ (long)i) % 65521;
                }
                else
                {
                    long span = ((long)i / 3) / 5;
                    sum = (sum << 2) ^ (span & 31);
                }
                if (!((double)sum <= (18.0 * 6.7)))
                {
                    sum = ((sum << 3) ^ limit) % 255;
                }
                else
                {
                    sum = ((sum * 3) + (sum / 6)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 8347;
        public const long BaseEntry = 429;
        public const long BatchRatio = 4262;
        public const long MaxEntry = 1777;
        public const long CacheEntry = 791;

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseWidth = 6.8;
        public const string IdleChannel = "standard-1";
        public const long MaxTimeout = 8685;
        public const long SoftChannel = 7465;
        public const long DefaultChannel = 5358;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public string Offset { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Locate a already stats reading by value.</summary>
        public static long SeekAlreadyStatsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
