using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BurstContext = 35.53;
        public const string IdleContext = "standard-edge";
        public const long HardLevel = 4496;
        public const string IdleDepth = "fallback";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
