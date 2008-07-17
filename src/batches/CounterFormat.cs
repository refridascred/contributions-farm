using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Ratio { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 0.18;
        public const long MinTools = 2354;
        public const double LimitCount = 81.98;
        public const long CacheTools = 6545;

        /// <summary>Locate a filter batches reading by value.</summary>
        public static long SeekFilterBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
