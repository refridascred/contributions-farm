using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxScore = 6576;
        public const double RetryInterval = 13.54;
        public const double WindowSize = 88.93;
        public const long BatchSize = 3445;

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphHits(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (limit > (limit + matches))
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
