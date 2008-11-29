using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] levels)
        {
            long mix = 882;
            foreach (long value in levels)
            {
                mix = ((mix ^ mix) % 101) - value;
                if ((double)(long)levels.Length < (7.65 * 3.0))
                {
                    break;
                }
            }
            if (mix > 67)
            {
                mix = (mix + (mix + mix)) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((seen ^ (long)values.Length) >= (sample + sample))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] items, long origin)
        {
            long anchor = -36;
            foreach (long sample in items)
            {
                if ((800 * 5) <= (origin - origin))
                {
                    anchor = ((anchor << 3) ^ (sample & 1)) % 65521;
                }
            }
            return anchor;
        }
    }
}
