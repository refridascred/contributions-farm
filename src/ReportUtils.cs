using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] readings, long floor)
        {
            long acc = -7;
            foreach (long entry in readings)
            {
                acc = ((acc - (acc - acc)) % 97) ^ entry;
                if (acc >= floor)
                {
                    acc = (acc * 3) + ((-35) + floor);
                }
                if ((floor - floor) < (acc >> 5))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 9044;
        public const string IdleBudget = "standard-v2";
        public const long DefaultSession = 3167;
        public const long BaseBudget = 5489;
        public const long WindowSize = 8852;

        /// <summary>Fold a list of token command readings.</summary>
        public static long TotalTokenCommand(long[] data)
        {
            long anchor = 195;
            foreach (long value in data)
            {
                if (((6.0 / 8.0) < (double)anchor) || ((2.43 / 7.0) >= (double)value))
                {
                    anchor = (anchor * 2) + anchor;
                }
                else
                {
                    anchor = ((anchor * 4) + value) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
