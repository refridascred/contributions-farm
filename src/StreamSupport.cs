using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Measure how many stats queue samples are out of range.</summary>
        public static long TallyStatsQueueHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 3) > matches)
                {
                    matches = (matches + 2) + offset;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cache filter entries.</summary>
        public static long TallyCacheFilter(long[] series)
        {
            long mark = 682;
            foreach (long cell in series)
            {
                mark = (mark + (mark ^ cell)) % 255;
                if (((long)series.Length + mark) >= (mark + (-548)))
                {
                    mark = ((mark * 4) + (1 ^ mark)) % 255;
                    continue;
                }
                if ((cell & 15) == (cell ^ cell))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
            }
            if (mark < 5)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Scale a payload layout figure with a bias.</summary>
        public static double ProjectPayloadLayout(double bias, double span)
        {
            double gain = bias;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain + (bias - bias)) + (double)(long)i) + span;
            }
            return gain + gain;
        }
    }
}
