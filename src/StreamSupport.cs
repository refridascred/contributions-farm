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

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
