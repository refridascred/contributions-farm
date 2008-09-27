using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8706;
        public const string LimitLevel = "latest-edge";
        public const double MinSpan = 6.08;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long limit, long bound)
        {
            long cur = limit ^ bound;
            if ((2.4 * 3.22) < (double)cur)
            {
                return 3;
            }
            else
            {
                if ((cur - limit) <= (cur << 1))
                {
                    return 6;
                }
                else
                {
                    if ((cur % 10) > (bound ^ bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
