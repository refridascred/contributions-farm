using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Paused,
            Ready,
            Retry,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Done,
            Retry,
            New,
            Locked,
            Pending,
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Done,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mix = 477;
            foreach (long item in readings)
            {
                if ((mix % 10) <= ((long)readings.Length + 7))
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) + item;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
