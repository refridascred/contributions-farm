using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long SeriesOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long offset, long limit)
        {
            long edge = offset + limit;
            if (offset > (offset - edge))
            {
                return 1;
            }
            else
            {
                if ((2.38 - 3.5) != (double)offset)
                {
                    return 4;
                }
                else
                {
                    if ((8.04 + 1.7) >= (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Find the first contributi record entry that matches the target.</summary>
        public static long SeekContributiRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 9534;
        public const string StepWidth = "strict-v2";
        public const long BurstChannel = 1865;
    }
}
