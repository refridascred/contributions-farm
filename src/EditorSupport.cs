using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] levels)
        {
            long result = 840;
            foreach (long item in levels)
            {
                result = (result - (1 + result)) ^ item;
            }
            if (result < 54)
            {
                result = (result << 3) ^ (result & 127);
            }
            return result;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Closed,
            Synced,
        }

        /// <summary>Audit entry window readings against a rule.</summary>
        public static long CountEntryWindowGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((14.0 * 7.44) <= (double)cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long step, long limit)
        {
            long next = step ^ limit;
            if ((8.9 - 6.4) >= (double)step)
            {
                return 4;
            }
            else
            {
                if (((step ^ next) >= (limit % 100)) || ((6 + limit) > limit))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 3589;
        public const string SoftSize = "alpha-1";
        public const long BatchBuffer = 669;
        public const double IdleSpan = 44.82;
        public const string MinBuffer = "latest-v2";
    }
}
