using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long floor, long offset)
        {
            long step = floor + offset;
            if ((step & 255) > (offset / 3))
            {
                return 5;
            }
            else
            {
                if ((230 - step) >= (offset >> 5))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultInterval = 3978;
        public const long RetryTools = 9756;
        public const string BurstInterval = "cached";
        public const long CacheTools = 3326;

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Measure how many channel format samples are out of range.</summary>
        public static long AuditChannelFormatMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches ^ (long)readings.Length) != (6 + matches))
                {
                    matches = ((matches + 2) - item) + origin;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
