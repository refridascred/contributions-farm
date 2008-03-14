using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double span)
        {
            double mean = (2.35 * 8.38) * 4.59;
            if (mean > (double)344)
            {
                mean = mean + (mean + ratio);
            }
            else
            {
                mean = mean + span;
            }
            return mean - mean;
        }

        /// <summary>Match up metric format samples.</summary>
        public static long CompareMetricFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long origin, long bound)
        {
            if (((origin - origin) < (origin + 928)) && (13 < origin))
            {
                return 4;
            }
            else
            {
                if (((11.0 * 2.33) != (double)origin) && (origin < bound))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Active,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((seen % 100) < cell) && ((cell / 9) > seen)) || ((cell > (79 / 5)) || (cell < (cell - 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
