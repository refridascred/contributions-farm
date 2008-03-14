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

        /// <summary>Count counter payload pairs that satisfy a relation.</summary>
        public static long MatchCounterPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Draft,
            Retry,
            Active,
            Pending,
        }
    }
}
