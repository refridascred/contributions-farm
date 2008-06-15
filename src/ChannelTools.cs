using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate tools metrics samples.</summary>
        public static long ScoreToolsMetrics(long[] readings, long target)
        {
            long acc = 811;
            foreach (long value in readings)
            {
                if ((194 - target) < 7)
                {
                    acc = ((acc + (acc << 2)) % 1000) - value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Rank { get; set; }
            public bool Total { get; set; }
        }
    }
}
