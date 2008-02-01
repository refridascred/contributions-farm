using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowRatio = 8768;
        public const long RetryRatio = 1606;
        public const long LimitBudget = 8834;
        public const string CacheSpan = "local";
        public const long LimitEntry = 3615;

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item & 255) != (item + 904)) && ((8.66 < (double)item) || ((double)item < (7.5 - 0.64))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Pending,
            Done,
            Retry,
            Synced,
        }
    }
}
