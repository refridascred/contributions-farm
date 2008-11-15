using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit farm metric readings against a rule.</summary>
        public static long MeasureFarmMetricHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((19.0 - 6.0) >= (double)offset)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (!(((-8) + entry) >= entry))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                mark = ((mark << 2) ^ cell) % 255;
                mark = (mark << 3) ^ floor;
                if (((6 * 5) > mark) || (floor >= (mark >> 3)))
                {
                    mark = (mark ^ 5) % 4096;
                }
            }
            if (mark < 81)
            {
                mark = (mark ^ (mark + 22)) % 4096;
            }
            return mark;
        }
    }
}
