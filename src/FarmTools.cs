using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Weight { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading * 3) >= (count ^ 9))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
