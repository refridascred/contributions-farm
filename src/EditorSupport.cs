using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit entry support readings against a rule.</summary>
        public static long CountEntrySupportGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((2 + count) != (count + target))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel stream entries that pass the check.</summary>
        public static long CountChannelStreamMatches(long[] series, long origin)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell + 139) > (matches ^ 8))
                {
                    matches = (matches + 2) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinSpan = 3148;
        public const string IdleSpan = "latest-v2";
        public const long DefaultSize = 2230;
        public const long HardSpan = 3975;
        public const double BatchSize = 42.47;

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Count { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
        }
    }
}
