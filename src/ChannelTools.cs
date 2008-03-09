using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 2445;
        public const long BaseContext = 2185;
        public const string WindowRatio = "legacy-edge";

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Locked,
            Idle,
            Active,
            Pending,
            Done,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if (!((item * 3) >= (acc / 4)))
                {
                    acc = (acc - (item - (-747))) % 255;
                }
            }
            return acc % 4096;
        }
    }
}
