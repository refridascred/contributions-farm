using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen < (seen - seen)) && ((item % 5) >= (item / 9)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchRoute = "cached";
        public const string BurstWidth = "strict-edge";
        public const long LimitRoute = 8481;
        public const long MinRoute = 4650;
    }
}
