using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BaseSpan = 3735;
        public const long DefaultScore = 451;
        public const long BaseContext = 1840;
        public const double HardScore = 85.36;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Offset { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Closed,
            Stale,
            New,
            Pending,
            Paused,
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Ready,
            Done,
            Paused,
            Queued,
            Failed,
        }

        /// <summary>Iterate the tools command series from a seed.</summary>
        public static long StepToolsCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    mix = ((mix * 3) + 898) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
