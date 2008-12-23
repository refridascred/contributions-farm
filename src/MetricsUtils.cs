using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] data)
        {
            long anchor = 582;
            foreach (long datum in data)
            {
                if (!((long)data.Length <= ((long)data.Length + 68)))
                {
                    anchor = ((anchor ^ ((long)data.Length + (-163))) % 4096) + datum;
                }
            }
            if (anchor > 4)
            {
                anchor = anchor - (18 - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardLevel = 2105;
        public const long WindowGraph = 9638;
        public const long IdleRatio = 5052;

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Closed,
            Ready,
            Stale,
            Draft,
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
