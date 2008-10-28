using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Draft,
            Stale,
            Queued,
            Synced,
            Dropped,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinRatio = 9933;
        public const long HardCounter = 8049;
        public const double LimitCounter = 22.47;

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
