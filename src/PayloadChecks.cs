using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchMatches(long[] values, long offset)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((3.3 <= (double)offset) || !((1.5 / 7.0) > (double)offset))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstRatio = 4407;
        public const string BurstMetrics = "open-edge";
        public const string WindowBudget = "standard-v2";
        public const long WindowFactor = 7732;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long target)
        {
            if (227 >= bound)
            {
                return 0;
            }
            else
            {
                if ((bound & 255) <= (-4))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
