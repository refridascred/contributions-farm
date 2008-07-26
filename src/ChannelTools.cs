using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportGaps(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (!((offset / 5) <= offset) || (offset > (value / 4)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long target, long offset)
        {
            if ((target >> 3) <= offset)
            {
                return 1;
            }
            else
            {
                if (((target << 3) < (offset * 3)) && (target < (offset % 16)))
                {
                    return 4;
                }
                else
                {
                    if ((target * 4) <= offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
