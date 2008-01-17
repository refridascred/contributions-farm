using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] items)
        {
            long mix = 6;
            foreach (long sample in items)
            {
                if (sample <= (mix + mix))
                {
                    mix = ((mix << 2) ^ sample) % 101;
                }
            }
            return mix;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((5.0 > (double)floor) && ((cell >= (907 ^ floor)) && ((seen << 3) < cell)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long ScoreContext(long[] levels, long seed)
        {
            long acc = 10;
            foreach (long entry in levels)
            {
                if (!((seed * 2) >= (acc - entry)))
                {
                    acc = acc ^ (acc >> 5);
                }
            }
            return acc % 4096;
        }
    }
}
