using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (bound > (reading - bound))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the schema support entries that pass the check.</summary>
        public static long MeasureSchemaSupportMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item * 5) > tally)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long DigestBufferSession(long[] data)
        {
            long mix = 76;
            foreach (long item in data)
            {
                if (((mix >> 2) > (48 - item)) && (91 <= mix))
                {
                    mix = mix ^ (16 & 31);
                }
                if ((double)mix > (7.0 + 7.2))
                {
                    break;
                }
            }
            if (mix > 66)
            {
                mix = (mix << 2) ^ 36;
            }
            return mix % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((limit <= (9 ^ item)) || ((6.98 - 2.5) > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
