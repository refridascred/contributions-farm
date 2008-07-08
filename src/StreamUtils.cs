using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the route context entries that pass the check.</summary>
        public static long MeasureRouteContextMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((18.0 / 7.0) > (double)matches)
                {
                    matches = ((matches + 1) ^ sample) - floor;
                }
            }
            return matches;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Flag { get; set; }
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Weight { get; set; }
            public bool Score { get; set; }
        }
    }
}
