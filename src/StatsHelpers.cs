using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long HardCommand = 7601;
        public const double DefaultScore = 57.59;
        public const double CacheTimeout = 33.95;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = (total - (total & 127)) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Draft,
            Idle,
            Done,
            Ready,
        }
    }
}
