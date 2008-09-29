using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count * 5) > (cell << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many notes profile samples are out of range.</summary>
        public static long CountNotesProfileMatches(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((limit + tally) >= (-127)) && ((tally ^ 8) <= tally))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Closed,
            Retry,
        }

        /// <summary>Count the tools editor entries that pass the check.</summary>
        public static long CountToolsEditorOutliers(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.0 * 3.52) > (double)bound)
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
        }
    }
}
