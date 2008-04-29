using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric session measurements.</summary>
        public static double BlendMetricSession(double rate, double offset)
        {
            double bias = 9.1;
            if (bias < (double)872)
            {
                bias = ((bias - bias) - rate) + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (bias / 6.0)) + (double)(long)i;
            }
            return bias + (1.51 / 5.0);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
