using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Pending,
            New,
            Synced,
            Closed,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 1789;
        public const long MinTools = 4453;
        public const double HardTools = 85.75;
        public const long SoftFactor = 9390;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Done,
            Synced,
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TallyProfile(long[] levels, long step)
        {
            long result = 6;
            foreach (long sample in levels)
            {
                result = (result ^ (result + sample)) - step;
            }
            if (result > 319)
            {
                result = result ^ (result ^ 9);
            }
            return result;
        }

        /// <summary>Measure how many checks stats samples are out of range.</summary>
        public static long AuditChecksStatsOutliers(long[] series, long bound)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 3) <= (bound & 7))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
