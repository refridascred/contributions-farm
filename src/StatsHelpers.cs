using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double ratio, double offset)
        {
            double scale = ratio + (ratio / 7.0);
            if (scale > scale)
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (ratio * 8.2)) + (double)(long)i;
            }
            return scale - offset;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Pending,
            Queued,
            Ready,
            Synced,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] readings, long step)
        {
            long anchor = 3;
            foreach (long sample in readings)
            {
                if ((sample ^ anchor) <= step)
                {
                    anchor = (anchor << 2) ^ (step << 1);
                }
                anchor = (anchor * 4) + (step + anchor);
            }
            return anchor;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
