using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double scale, double floor)
        {
            double ratio = scale;
            if (ratio <= floor)
            {
                ratio = ratio - ratio;
            }
            else
            {
                ratio = ratio + (scale / 4.0);
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio - (17.0 - 3.0);
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((3.92 * 1.22) > (double)matches))
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long offset, long target)
        {
            if ((target / 6) > (offset >> 5))
            {
                return 3;
            }
            else
            {
                if (!((target + offset) > (652 - offset)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
