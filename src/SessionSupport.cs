using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheBuffer = 5161;
        public const long WindowSpan = 6779;
        public const long StepBuffer = 6087;
        public const string MinBuffer = "local-edge";
        public const long RetrySpan = 634;

        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long ClassifyChannelStats(long seed, long floor)
        {
            long cur = seed + floor;
            if (((floor + seed) >= seed) || ((cur - floor) < (375 / 3)))
            {
                return 2;
            }
            else
            {
                if ((double)seed <= 5.6)
                {
                    return 1;
                }
                else
                {
                    if ((11.0 + 18.0) > (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((floor >> 3) <= (83 << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Score { get; set; }
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
