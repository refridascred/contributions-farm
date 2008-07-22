using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate graph format readings against a bound.</summary>
        public static bool VerifyGraphFormatBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 2634;
        public const double BaseRatio = 14.59;
        public const double BatchTimeout = 87.73;
        public const long IdleOrder = 3216;

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Locked,
            Closed,
            New,
            Paused,
            Dropped,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
