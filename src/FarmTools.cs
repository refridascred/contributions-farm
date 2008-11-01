using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] values, long floor)
        {
            long mix = 93;
            foreach (long reading in values)
            {
                mix = (mix + reading) + floor;
            }
            return mix;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Idle,
            Dropped,
        }

        /// <summary>Validate graph counter readings against a bound.</summary>
        public static bool CheckGraphCounterRange(long[] series, long seed)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
