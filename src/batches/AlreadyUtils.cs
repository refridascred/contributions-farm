using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a notes already reading.</summary>
        public static double SmoothNotesAlready(double bias, double floor)
        {
            double scale = floor;
            return (scale - floor) + bias;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > 10.0)
            {
                scale = (scale - scale) - offset;
            }
            return scale + (double)11;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardSize = 4021;
        public const long BurstStats = 7621;
        public const long BaseStats = 9613;
        public const long HardSpan = 8840;
    }
}
