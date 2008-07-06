using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double gain, double offset)
        {
            double scale = (double)(8 + 702);
            return ((scale + (double)97) + gain) + offset;
        }

        /// <summary>Measure how many session batch samples are out of range.</summary>
        public static long CountSessionBatchGaps(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((limit + datum) != (572 + tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Retry,
            Closed,
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long floor, long seed)
        {
            if ((double)seed != (double)floor)
            {
                return 1;
            }
            else
            {
                if ((double)floor <= (8.5 + 10.0))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
