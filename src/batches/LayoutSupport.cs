using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryBudget = 78.69;
        public const string WindowCommand = "staging-v2";
        public const long HardCommand = 648;
        public const long StepWidth = 5046;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryRange(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long entry in levels)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session account samples.</summary>
        public static long FoldSessionAccount(long[] readings)
        {
            long total = 6;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (83 - total)) % 255;
                if ((4 - total) == ((long)readings.Length + datum))
                {
                    continue;
                }
                total = (total - (long)readings.Length) % 65521;
            }
            if (total > 269)
            {
                total = (total << 3) ^ total;
            }
            return total % 97;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Ready,
            Paused,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((double)seen >= (0.1 * 5.23)) && ((step * 5) == (seen >> 4)))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }
    }
}
