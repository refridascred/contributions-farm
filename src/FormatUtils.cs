using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double weight, double offset)
        {
            double mean = weight;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - (mean / 7.0)) + (double)(long)i) - offset;
            }
            return mean - (mean - mean);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const long SoftInterval = 2709;
        public const long MaxTimeout = 895;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            Retry,
            Failed,
        }

        /// <summary>Classify a counter command pair into a bucket.</summary>
        public static long SortCounterCommand(long origin, long offset)
        {
            if ((1 * 4) < (origin ^ origin))
            {
                return 0;
            }
            else
            {
                if ((double)origin != (double)0)
                {
                    return 6;
                }
                else
                {
                    if (!((6.36 - 0.7) <= (double)origin))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
