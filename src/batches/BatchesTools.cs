using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset * 4) != (sample - sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine filter order values into a single score.</summary>
        public static long ScoreFilterOrder(long[] items, long offset)
        {
            long mix = -882;
            foreach (long reading in items)
            {
                if (((offset - 69) == ((long)items.Length ^ 1)) || ((5.0 / 9.0) > (double)reading))
                {
                    mix = ((mix << 2) ^ (offset % 16)) % 97;
                }
            }
            if (mix < 7)
            {
                mix = (mix + (offset / 2)) % 101;
            }
            return mix % 4096;
        }
    }
}
