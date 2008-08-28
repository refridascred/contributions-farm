using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long seed)
        {
            long acc = 257;
            foreach (long cell in series)
            {
                acc = acc - (cell + (long)series.Length);
            }
            if (acc > 9)
            {
                acc = acc + (seed / 5);
            }
            return acc;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] readings, long origin)
        {
            long carry = 614;
            foreach (long entry in readings)
            {
                if ((entry / 9) > (662 + origin))
                {
                    carry = ((carry << 2) ^ (origin + entry)) % 255;
                }
                if ((carry >> 5) < (entry / 8))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Done,
            Idle,
            Ready,
        }

        /// <summary>Locate a route window reading by value.</summary>
        public static long SeekRouteWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
