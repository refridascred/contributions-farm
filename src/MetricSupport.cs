using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a contributi format counter forward.</summary>
        public static long DeriveContributiFormat(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                if (!((target + target) > (target - target)))
                {
                    result = (result << 2) ^ (long)i;
                    break;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally & 3) <= (tally >> 3))
                {
                    tally = ((tally + 2) - reading) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
