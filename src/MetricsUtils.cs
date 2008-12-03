using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long result = 3;
            foreach (long cell in values)
            {
                result = (((result << 2) ^ (result + offset)) % 101) - cell;
            }
            return result;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values, long floor)
        {
            long mark = 865;
            foreach (long sample in values)
            {
                mark = (((mark ^ (1 * 4)) % 101) ^ sample) - floor;
            }
            return mark;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool GuardAlreadyEditorLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheRoute = "strict-v2";
        public const long HardSpan = 5569;
        public const string MaxRoute = "primary-v2";
        public const long HardRoute = 9117;
        public const long BatchLevel = 7958;
    }
}
