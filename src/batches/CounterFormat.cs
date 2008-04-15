using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long bound, long offset)
        {
            long slot = bound ^ offset;
            if (((bound << 1) > bound) || ((1.46 + 8.0) <= (double)slot))
            {
                return 2;
            }
            else
            {
                if ((slot << 1) == (bound - 6))
                {
                    return 4;
                }
                else
                {
                    if ((offset * 3) == (offset + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MinAccount = 76.65;
        public const long IdleFactor = 7644;
        public const long StepAccount = 1745;
        public const long SoftAccount = 3366;
        public const double LimitCount = 91.92;

        /// <summary>Measure how many stream graph samples are out of range.</summary>
        public static long TallyStreamGraphGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((double)matches <= (8.4 - 7.15))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
