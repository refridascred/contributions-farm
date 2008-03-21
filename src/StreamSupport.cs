using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long bound, long origin)
        {
            if ((double)origin >= (7.0 + 4.2))
            {
                return 6;
            }
            else
            {
                if ((20 << 1) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (!((81 + bound) <= 72))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultCounter = 38.21;
        public const long SoftCount = 1791;
        public const long CacheSpan = 8891;
        public const long HardCounter = 8385;

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
