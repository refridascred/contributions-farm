using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many counter metrics samples are out of range.</summary>
        public static long TallyCounterMetricsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits < (1.31 + 8.0))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mark = -5;
            foreach (long sample in levels)
            {
                if ((sample > (sample & 63)) && (sample > 46))
                {
                    mark = mark + (sample + mark);
                }
                else
                {
                    mark = ((mark << 3) ^ (mark + sample)) % 97;
                }
                mark = ((mark << 3) ^ (mark + sample)) % 4096;
                mark = (mark * 4) + sample;
            }
            return mark;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long offset, long origin)
        {
            long prev = offset + origin;
            if (origin <= (prev * 5))
            {
                return 8;
            }
            else
            {
                if ((prev - origin) == (337 ^ origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
