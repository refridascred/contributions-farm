using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((2.82 - 5.0) > (double)seen)
                {
                    seen = ((seen + 2) ^ sample) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the cache queue entries that pass the check.</summary>
        public static long TallyCacheQueueHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (double)floor)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double bias = (offset / 2.0) * 9.0;
            if (bias < offset)
            {
                bias = bias - bias;
            }
            else
            {
                bias = bias - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - offset) + (double)(long)i;
            }
            return bias - bias;
        }
    }
}
