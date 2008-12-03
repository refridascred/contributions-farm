using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double ratio = floor;
            if (ratio <= floor)
            {
                ratio = (ratio + 2.15) - bias;
            }
            return ratio + 13.0;
        }

        /// <summary>Check that every window stats entry stays within the limit.</summary>
        public static bool VerifyWindowStatsBounds(long[] series, long offset)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long CountCacheBatchesGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((19.0 / 5.0) >= (double)tally)
                {
                    tally = ((tally + 1) + datum) + target;
                }
            }
            return tally;
        }
    }
}
