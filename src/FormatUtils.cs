using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Iterate the batch entry series from a seed.</summary>
        public static long SeriesBatchEntry(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 19; i++)
            {
                carry = carry + (carry + carry);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long seed, long seed2)
        {
            if ((seed2 ^ (-151)) > seed)
            {
                return 4;
            }
            else
            {
                if ((seed2 >= (984 - seed2)) || (661 >= (seed2 + 1)))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed2 < 5.5)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSession = 40.8;
        public const long BurstSession = 3708;
        public const double MaxSession = 78.14;
        public const string BatchSpan = "stable";
        public const double RetrySession = 84.01;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryDepth = 9036;
        public const double BurstProfile = 22.77;
        public const long SoftSize = 7466;
        public const long RetryProfile = 2818;
        public const string CacheBudget = "alpha-edge";

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Stamp { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
