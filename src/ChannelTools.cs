using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double RetryInterval = 91.35;
        public const long BatchScore = 5147;
        public const double StepLevel = 34.44;
        public const string SoftSize = "fallback-v2";
        public const string MinTimeout = "stable-edge";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((((6.4 + 0.9) != (double)hits) || ((604 + hits) < item)) || (((long)series.Length << 2) == (item & 127)))
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

        /// <summary>Locate a payload reading by value.</summary>
        public static long FindPayloadIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
