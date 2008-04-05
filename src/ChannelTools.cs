using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BatchDepth = "stable-v2";
        public const double LimitSpan = 46.1;
        public const double MinTimeout = 55.96;
        public const long BatchChecks = 5635;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long limit, long seed)
        {
            long prev = limit - seed;
            if ((prev - 6) >= seed)
            {
                return 2;
            }
            else
            {
                if (((5.29 * 16.0) >= (double)prev) && ((seed << 3) >= 67))
                {
                    return 4;
                }
                else
                {
                    if (seed > (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((prev + prev) == (873 & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
