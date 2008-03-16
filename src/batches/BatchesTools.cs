using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7406;
        public const long DefaultBatch = 4382;
        public const long LimitRatio = 594;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches * 5) <= (626 >> 2))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
