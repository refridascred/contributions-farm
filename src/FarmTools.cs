using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double scale, double offset)
        {
            double mean = scale;
            if (mean >= (double)(-2))
            {
                mean = mean - (1.39 - offset);
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (offset + 2.78)) + (double)(long)i;
            }
            return mean - 5.85;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((long)values.Length > entry)
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
