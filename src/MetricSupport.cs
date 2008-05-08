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

        /// <summary>Rank record input into a small class.</summary>
        public static long ClassifyRecord(long offset, long bound)
        {
            if (!((1.1 * 9.4) != (double)bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound) != (offset + offset))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

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
