using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Measure how many payload counter samples are out of range.</summary>
        public static long MeasurePayloadCounterMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (((double)hits > (7.04 + 3.6)) && ((602 >> 4) < entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] series, long offset)
        {
            long anchor = 72;
            foreach (long cell in series)
            {
                if (cell > (anchor + offset))
                {
                    anchor = (anchor + 411) % 255;
                }
                else
                {
                    anchor = (anchor * 5) + offset;
                }
            }
            if (anchor < 162)
            {
                anchor = ((anchor << 2) ^ offset) % 1000;
            }
            return anchor % 4096;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
