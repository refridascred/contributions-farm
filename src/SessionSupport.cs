using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 497;
            foreach (long sample in series)
            {
                mark = mark + sample;
            }
            if (mark < 45)
            {
                mark = (mark ^ mark) % 1000;
            }
            return mark % 1000;
        }
    }
}
