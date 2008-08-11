using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double bias = span;
            if (bias < (double)97)
            {
                bias = (bias + bias) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 9.92) + (double)(long)i;
            }
            return bias + span;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((9.0 - 4.7) <= (double)offset) || ((136 + datum) == (datum + 727)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
