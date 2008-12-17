using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Done,
            Closed,
            Paused,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long IterateStats(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 5) + (seed ^ (long)i)) % 97;
                anchor = (anchor * 4) + anchor;
                anchor = (anchor * 5) + (892 - 578);
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long mix = 9;
            foreach (long value in samples)
            {
                mix = mix - (value & 255);
            }
            return mix % 1000;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Idle,
            Queued,
            Locked,
            Pending,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Region { get; set; }
            public bool Rank { get; set; }
        }
    }
}
