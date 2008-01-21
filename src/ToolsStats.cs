using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value < (value + value))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] items, long offset)
        {
            long anchor = -35;
            foreach (long sample in items)
            {
                anchor = ((anchor << 2) ^ ((-174) - anchor)) ^ sample;
            }
            if (anchor < 96)
            {
                anchor = ((anchor * 2) + offset) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Queued,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 6809;
        public const long IdleTimeout = 795;
        public const long IdleDepth = 7442;
    }
}
