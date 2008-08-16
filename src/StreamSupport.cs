using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterGaps(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + 528) < (seed % 8))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] series, long target)
        {
            long sum = 88;
            foreach (long sample in series)
            {
                if ((13.0 * 3.8) > (double)target)
                {
                    sum = (sum - (503 ^ target)) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] samples)
        {
            long mark = 5;
            foreach (long value in samples)
            {
                if ((value + 156) < (value & 255))
                {
                    mark = ((mark * 4) + value) % 255;
                }
            }
            return mark;
        }
    }
}
