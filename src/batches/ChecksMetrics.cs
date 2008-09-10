using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 92.74;
        public const double BaseFilter = 43.99;
        public const long IdleCount = 8244;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
            public double Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next editor channel value from a seed.</summary>
        public static long SeriesEditorChannel(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((acc <= 12) && ((origin + origin) == (acc * 3)))
                {
                    acc = ((acc << 3) ^ ((-2) >> 2)) % 65521;
                    break;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
