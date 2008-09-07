using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ (step * 2)) % 255;
                sum = (sum ^ (sum & 31)) % 1000;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many checks channel samples are out of range.</summary>
        public static long TallyChecksChannelOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (0 <= (391 + hits))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((0 >= (step + step)) || (step < seen)) && (reading > (seen + seen)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
