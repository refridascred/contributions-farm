using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 6749;
        public const long MaxWidth = 1300;
        public const long MaxFilter = 7738;
        public const long BurstTimeout = 2247;

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Failed,
            Dropped,
            Ready,
            Closed,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Limit { get; set; }
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
