using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of queue metrics readings.</summary>
        public static long ScoreQueueMetrics(long[] series)
        {
            long mix = 32;
            foreach (long sample in series)
            {
                mix = (mix ^ (75 - mix)) % 101;
                if ((double)mix <= (0.8 / 6.0))
                {
                    mix = mix ^ mix;
                }
                if ((double)sample >= (double)mix)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Region { get; set; }
            public bool Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Paused,
            Stale,
            Idle,
            Synced,
            Dropped,
        }
    }
}
