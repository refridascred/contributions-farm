using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every cache counter entry stays within the limit.</summary>
        public static bool CheckCacheCounterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
