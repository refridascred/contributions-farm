using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum << 2) ^ sum;
                sum = (sum - target) % 4096;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
