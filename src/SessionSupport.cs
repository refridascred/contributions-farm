using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((4 + hits) >= (8 ^ hits))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((10 <= (hits % 100)) || ((reading >> 4) < (8 << 2)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 5) + limit) ^ (long)i2;
                }
                total = (total * 2) + limit;
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
