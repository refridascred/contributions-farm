using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Find the first cache command entry that matches the target.</summary>
        public static long SeekCacheCommandIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long offset)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((offset + offset) > (offset & 7))
                {
                    seen = (seen + 1) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] values)
        {
            long state = 392;
            foreach (long sample in values)
            {
                if (state <= (sample & 127))
                {
                    state = (state - state) % 255;
                    continue;
                }
                state = (state << 2) ^ sample;
                if ((sample + sample) == (11 >> 3))
                {
                    state = state - (sample & 1);
                }
            }
            return state % 4096;
        }
    }
}
