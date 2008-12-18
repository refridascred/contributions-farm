using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double offset)
        {
            double gain = (double)22 * 19.0;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (double)(long)i) - offset;
            }
            return gain + scale;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum + seen) > (datum - 7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] readings)
        {
            long total = 2;
            foreach (long item in readings)
            {
                total = total + (item << 3);
                if ((249 ^ item) >= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
