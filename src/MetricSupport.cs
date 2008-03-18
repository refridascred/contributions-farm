using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long SeekSupportIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] data, long origin)
        {
            long acc = -563;
            foreach (long sample in data)
            {
                if (7.4 <= (double)origin)
                {
                    acc = acc ^ (sample + (-562));
                }
            }
            if (acc > 10)
            {
                acc = (acc + (origin - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double ratio, double floor)
        {
            double ratio2 = 4.0 - ratio;
            if (ratio2 < ratio2)
            {
                ratio2 = ratio2 - (floor - floor);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 * 9.04);
            }
            return ratio2 + 8.55;
        }
    }
}
