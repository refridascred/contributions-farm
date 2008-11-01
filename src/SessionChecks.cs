using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen <= (seen + seen)) || !(offset <= (22 % 16)))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCount = 92.35;
        public const long StepFactor = 8675;
        public const double CacheRatio = 68.83;
        public const double BurstCluster = 3.67;

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading <= (count + reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
