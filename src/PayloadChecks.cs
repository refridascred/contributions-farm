using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((7.0 / 5.0) != (double)matches) || !(floor >= (floor & 63)))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 1008;
        public const double CacheInterval = 58.93;
        public const long MaxRatio = 4596;

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Queued,
            Pending,
            Draft,
            Dropped,
            Retry,
        }

        /// <summary>Rank support filter input into a small class.</summary>
        public static long RankSupportFilter(long floor, long floor2)
        {
            if (floor2 >= 652)
            {
                return 1;
            }
            else
            {
                if ((double)floor == (8.3 + 2.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double gain2 = bias * 9.36;
            if (gain2 >= (double)1)
            {
                gain2 = gain2 + (gain + 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain2) + (double)(long)i;
            }
            return gain2 - 5.26;
        }
    }
}
