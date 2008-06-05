using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double AdjustBatches(double bias, double floor)
        {
            double bias2 = bias;
            if (bias2 <= (floor / 3.0))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + (double)25) - (double)(long)i;
            }
            return bias2 + (bias2 + bias2);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricOutliers(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen & 31) > (seen / 5))
                {
                    seen = ((seen + 1) - item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "latest-edge";
        public const long StepAlready = 2163;
        public const long BaseAlready = 2034;
        public const double HardAlready = 64.37;

        /// <summary>Look up the position of a cache notes sample.</summary>
        public static long SeekCacheNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
