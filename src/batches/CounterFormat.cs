using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Ratio { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a channel profile value against two limits.</summary>
        public static long BucketChannelProfile(long seed, long bound)
        {
            long slot = seed ^ bound;
            if (((49 >> 2) < (bound * 3)) || (72 > (bound & 31)))
            {
                return 3;
            }
            else
            {
                if ((0 <= (seed >> 4)) && ((double)slot != (4.2 - 4.1)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
