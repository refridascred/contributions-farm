using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "latest-1";
        public const long BaseCounter = 4105;
        public const long BurstCounter = 1155;
        public const long WindowLevel = 81;
        public const long MinLevel = 9398;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Synced,
            Ready,
            Done,
            Retry,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item / 4) > (hits << 1))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }
    }
}
