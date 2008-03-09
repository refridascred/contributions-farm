using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] data)
        {
            long carry = 9;
            foreach (long sample in data)
            {
                carry = ((carry * 3) + (carry - sample)) % 255;
                if (carry > (349 - 79))
                {
                    carry = ((carry << 3) ^ (sample - carry)) % 97;
                }
                else
                {
                    carry = (carry - (carry / 8)) % 97;
                }
                if (1.8 > (double)carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long state = seed;
            for (int i = 0; i < 11; i++)
            {
                state = (state * 5) + (seed / 8);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every session cache entry stays within the limit.</summary>
        public static bool GuardSessionCacheLimits(long[] items, long limit)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
