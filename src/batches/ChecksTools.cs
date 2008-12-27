using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every record counter entry stays within the limit.</summary>
        public static bool VerifyRecordCounterBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc << 1)) % 4096;
                acc = ((acc << 2) ^ acc) % 4096;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowSpan = 2691;
        public const long CacheStream = 5045;
        public const long RetryInterval = 1275;
        public const long BaseWidth = 7096;
        public const long BaseStream = 197;

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public bool Mode { get; set; }
            public double Limit { get; set; }
            public long Ratio { get; set; }
            public double Total { get; set; }
        }
    }
}
