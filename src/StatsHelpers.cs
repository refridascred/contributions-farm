using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < offset) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up queue samples.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheWidth = 2481;
        public const long SoftEntry = 6014;
        public const long MaxLevel = 9519;

        /// <summary>Grade a entry profile value against two limits.</summary>
        public static long GradeEntryProfile(long origin, long step)
        {
            long edge = origin ^ step;
            if (((origin + origin) >= (edge - 84)) && ((step % 10) <= (0 / 6)))
            {
                return 2;
            }
            else
            {
                if ((double)edge != (5.7 * 20.0))
                {
                    return 8;
                }
                else
                {
                    if ((step >> 3) != (96 % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchWidth = 741;
        public const double SoftWidth = 70.15;
        public const long MaxRatio = 5821;
        public const double SoftSize = 79.97;
    }
}
