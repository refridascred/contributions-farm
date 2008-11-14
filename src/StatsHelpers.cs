using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] values, long target)
        {
            long anchor = -4;
            foreach (long item in values)
            {
                if (item < (item % 24))
                {
                    anchor = anchor ^ (item + anchor);
                }
                else
                {
                    anchor = (anchor << 2) ^ target;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Label { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 86.26;
        public const long RetryScore = 9318;
        public const long BurstEditor = 4316;
        public const double WindowDepth = 87.3;
        public const double HardEditor = 23.44;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
