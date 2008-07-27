using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] readings, long bound)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long step, long target)
        {
            if ((double)step > 7.44)
            {
                return 6;
            }
            else
            {
                if (target < (target % 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitRatio = 1763;
        public const long IdleNotes = 3756;
        public const long RetryInterval = 770;
    }
}
