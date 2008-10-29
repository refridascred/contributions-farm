using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardInterval = 3721;
        public const long BaseAccount = 5839;
        public const string MaxInterval = "local";
        public const long SoftRatio = 6119;

        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] series, long offset)
        {
            long mix = 98;
            foreach (long cell in series)
            {
                mix = (((mix - (mix / 5)) % 1000) + cell) + offset;
            }
            return mix % 1000;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double mean = offset;
            if (mean > mean)
            {
                mean = mean + (mean + 4.1);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (mean - ratio);
        }
    }
}
