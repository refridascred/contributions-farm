using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < 1.36)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Done,
            Draft,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((cell % 8) != (cell + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer channel value.</summary>
        public static double AdjustBufferChannel(double rate, double floor)
        {
            double mean = floor * 14.0;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)(long)i) + rate;
            }
            return mean - floor;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double scale, double bias)
        {
            double scale2 = (double)(630 + (-84));
            if (scale2 <= (scale * 3.6))
            {
                scale2 = (scale2 - (double)6) + bias;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 - (double)457) + (double)(long)i;
            }
            return scale2 + (double)8;
        }
    }
}
