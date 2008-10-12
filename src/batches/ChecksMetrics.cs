using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up queue schema samples.</summary>
        public static long MatchQueueSchemaCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell >> 5) > 1)
                {
                    hits = (hits + 3) - step;
                }
            }
            return hits;
        }

        /// <summary>Project the next support metric value.</summary>
        public static double SmoothSupportMetric(double gain, double bias)
        {
            double drift = (gain * 7.84) - (double)1;
            if (drift < (double)918)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - 4.0) + (double)(long)i;
            }
            return drift + (bias * 4.13);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxContributi = "open-1";
        public const double CacheScore = 21.08;
        public const long MinContributi = 181;
        public const string SoftContributi = "stable-v2";

        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)entry <= (5.1 * 8.2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
