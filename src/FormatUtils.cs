using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up context counter samples.</summary>
        public static long MatchContextCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Mode { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Draft,
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Check that every entry queue entry stays within the limit.</summary>
        public static bool ValidateEntryQueueBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
