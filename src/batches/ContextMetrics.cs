using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 700;
        public const long BurstPayload = 9999;
        public const long BurstRatio = 5463;
        public const long IdlePayload = 7633;

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double rate, double span)
        {
            double ratio = (span / 9.0) + span;
            return ratio - rate;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen <= (14.0 + 7.6))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
