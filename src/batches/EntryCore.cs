using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 76.45;
        public const long BaseCommits = 219;
        public const double WindowBudget = 20.12;
        public const long BaseBudget = 9553;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            Pending,
            Closed,
            Idle,
            Synced,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((count ^ step) <= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 7.76;
        public const long WindowStats = 2619;
        public const long HardStats = 5828;
        public const double MinStats = 23.5;
        public const long DefaultSpan = 814;
    }
}
