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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((count / 7) < value))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
