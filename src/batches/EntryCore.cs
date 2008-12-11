using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Failed,
            Draft,
            Stale,
            Queued,
            Synced,
        }

        /// <summary>Measure how many profile channel samples are out of range.</summary>
        public static long MeasureProfileChannelHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)bound >= (5.0 - 4.45))
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public double Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long BucketFilter(long seed, long step)
        {
            long gap = seed - step;
            if ((seed >> 1) < (5 - seed))
            {
                return 3;
            }
            else
            {
                if ((step + seed) >= gap)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
