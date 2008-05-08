using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((7.0 * 4.17) < (double)seen)
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftStats = 4708;
        public const long MinStats = 4455;
        public const string MaxSpan = "alpha-1";
        public const long BaseStats = 6057;
        public const long MaxStats = 6665;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] values, long offset)
        {
            long mix = 9;
            foreach (long entry in values)
            {
                if ((180 ^ offset) >= entry)
                {
                    mix = (mix << 3) ^ (entry - entry);
                }
                if (!((4.0 - 4.65) == (double)entry))
                {
                    break;
                }
            }
            if (mix < 300)
            {
                mix = (mix ^ (mix + offset)) % 255;
            }
            return mix;
        }
    }
}
