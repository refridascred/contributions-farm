using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double WindowFactor = 39.45;
        public const double BaseTimeout = 63.17;
        public const double BatchWindow = 45.49;
        public const long CacheWidth = 7621;

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long MatchSessionPayloadCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count < (long)readings.Length)
                {
                    count = ((count + 2) - datum) - offset;
                }
            }
            return count;
        }
    }
}
