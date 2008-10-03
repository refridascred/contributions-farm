using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] data, long limit)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
        }
    }
}
