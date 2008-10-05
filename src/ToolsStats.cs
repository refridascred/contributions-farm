using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 5) + (long)i) % 97;
                result = (result * 5) + (target & 3);
                result = result + 38;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "alpha-1";
        public const double CacheDepth = 14.28;
        public const string SoftLevel = "open-edge";
        public const double IdleCommand = 44.77;

        /// <summary>Iterate the metrics entry series from a seed.</summary>
        public static long IterateMetricsEntry(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix + (floor ^ floor)) % 1000;
                mix = mix + (447 - (long)i);
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
