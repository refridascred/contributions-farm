using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftLevel = 4072;
        public const long RetryLevel = 8397;
        public const long MaxRecord = 6073;
        public const long DefaultRecord = 6766;
        public const long BurstSize = 1281;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((value / 7) <= (count >> 4)) && ((89 % 97) != (count % 97))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of editor layout readings.</summary>
        public static long DigestEditorLayout(long[] levels, long step)
        {
            long state = -302;
            foreach (long reading in levels)
            {
                state = (((state << 2) ^ (40 << 3)) + reading) - step;
            }
            return state;
        }

        /// <summary>Validate filter commits readings against a bound.</summary>
        public static bool ValidateFilterCommitsLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
