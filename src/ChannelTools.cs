using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Stale,
            Locked,
            Closed,
            Failed,
            Queued,
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Token { get; set; }
            public long Size { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Validate counter layout readings against a bound.</summary>
        public static bool ValidateCounterLayoutLimits(long[] series, long seed)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
