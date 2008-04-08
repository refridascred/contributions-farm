using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long floor)
        {
            if (!((floor >> 5) <= (floor & 3)))
            {
                return 3;
            }
            else
            {
                if ((double)floor > 7.96)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] data)
        {
            long score = 8;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ (178 * 5)) ^ datum;
            }
            if (score > 86)
            {
                score = score ^ (score - score);
            }
            return score % 4096;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Failed,
            Synced,
            Retry,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Pending,
            Done,
            Retry,
            Stale,
            Queued,
        }

        /// <summary>Adjust a checks queue reading.</summary>
        public static double SmoothChecksQueue(double gain, double bias)
        {
            double mean = gain;
            if (mean > (double)607)
            {
                mean = (mean + gain) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (6.3 / 9.0)) + (double)(long)i;
            }
            return mean + (18.0 / 8.0);
        }
    }
}
