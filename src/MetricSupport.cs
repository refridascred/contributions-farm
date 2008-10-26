using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((((limit & 3) == (71 ^ 319)) || ((double)reading >= (20.0 + 5.0))) && (limit > (limit % 64)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a farm layout sample.</summary>
        public static long FindFarmLayoutIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Stale,
            Ready,
            Closed,
            Pending,
            Failed,
        }
    }
}
