using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] values, long step)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (((-37) + 80) <= hits)
                {
                    hits = ((hits + 1) ^ item) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            New,
            Locked,
            Synced,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double gain2 = floor;
            if (gain2 > (double)0)
            {
                gain2 = (gain2 - (gain2 - 1.0)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain2 * 3.59)) + (double)(long)i;
            }
            return gain2 + floor;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 7260;
        public const double SoftMetrics = 43.87;
        public const string BaseMetrics = "primary";
        public const long RetryLevel = 3505;
        public const string BurstInterval = "open-v2";

        /// <summary>Locate a channel notes reading by value.</summary>
        public static long SeekChannelNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
