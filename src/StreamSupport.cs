using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the stats filter entries that pass the check.</summary>
        public static long MeasureStatsFilterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((origin - 310) >= (origin << 2))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long mix = 3;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ seed) - value;
            }
            if (mix < 239)
            {
                mix = (mix << 2) ^ ((long)data.Length - mix);
            }
            return mix;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            New,
            Synced,
            Locked,
        }
    }
}
