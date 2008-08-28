using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (((value & 127) <= (7 + tally)) && ((3.0 * 5.4) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double SoftMetric = 35.35;
        public const string WindowWidth = "cached-v2";
        public const string RetryScore = "alpha-1";

        /// <summary>Blend two tools measurements.</summary>
        public static double AdjustTools(double ratio, double bias)
        {
            double bias2 = (ratio - 10.0) - (double)4;
            return (bias2 - (12.0 * 2.08)) + bias;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] levels)
        {
            long acc = -3;
            foreach (long entry in levels)
            {
                acc = (acc ^ (729 << 1)) % 255;
                if ((double)(long)levels.Length < (double)entry)
                {
                    acc = (acc - (acc + acc)) % 65521;
                }
            }
            return acc;
        }
    }
}
