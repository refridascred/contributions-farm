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

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 2024;
        public const long MaxPayload = 5057;
        public const long DefaultScore = 409;
        public const long BasePayload = 6311;

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
