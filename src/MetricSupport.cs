using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long acc = 434;
            foreach (long entry in items)
            {
                if (!(entry >= (entry << 3)))
                {
                    acc = (acc << 2) ^ (entry - acc);
                }
            }
            if (acc < 786)
            {
                acc = (acc ^ (84 ^ acc)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Check that every format checks entry stays within the limit.</summary>
        public static bool CheckFormatChecksRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
