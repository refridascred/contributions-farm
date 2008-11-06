using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Closed,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public bool Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double AdjustLayout(double rate, double offset)
        {
            double gain = (double)(3 * 2);
            if (gain > (14.0 + 6.0))
            {
                gain = (gain - offset) - rate;
            }
            else
            {
                gain = gain - 20.0;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain - (offset - offset);
        }
    }
}
