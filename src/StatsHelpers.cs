using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Locked,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 941;
        public const long MaxReport = 526;
        public const long IdleWidth = 4742;

        /// <summary>Count the metric editor entries that pass the check.</summary>
        public static long MeasureMetricEditorGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits ^ 5) > (item + item))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Region { get; set; }
            public long Size { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Look up the position of a payload commits sample.</summary>
        public static long LocatePayloadCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
