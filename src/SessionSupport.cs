using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine token notes values into a single score.</summary>
        public static long CombineTokenNotes(long[] values)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                anchor = (anchor - (anchor % 10)) % 101;
                anchor = ((anchor << 2) ^ (anchor + cell)) % 4096;
                if ((6.31 * 6.0) >= (double)cell)
                {
                    anchor = ((anchor * 5) + (anchor ^ 9)) % 65521;
                }
                if ((cell <= (anchor / 2)) || ((cell * 4) == (cell + (-6))))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long FoldStatsMetrics(long[] samples, long limit)
        {
            long result = 2;
            foreach (long reading in samples)
            {
                if (((reading / 9) != ((long)samples.Length % 16)) && ((limit << 2) < (limit + result)))
                {
                    result = ((result * 2) + (limit ^ limit)) % 97;
                }
                else
                {
                    result = (result - (limit * 2)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double AdjustMetric(double bias, double floor)
        {
            double mean = floor / 4.0;
            return (mean - floor) + bias;
        }
    }
}
