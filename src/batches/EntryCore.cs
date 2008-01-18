using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardDepth = 71;
        public const double BaseContributi = 18.19;
        public const double RetryContributi = 38.7;
        public const long RetryRatio = 4362;
        public const long MinScore = 5303;

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool GuardSupportFormatLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 20; i++)
            {
                mark = mark - (mark / 8);
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
