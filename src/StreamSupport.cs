using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels, long floor)
        {
            long acc = 1;
            foreach (long datum in levels)
            {
                if ((acc + floor) <= (datum - datum))
                {
                    acc = acc ^ (acc - acc);
                }
                if (((acc / 6) > (long)levels.Length) && ((double)datum > (3.23 - 4.48)))
                {
                    break;
                }
            }
            if (acc > 24)
            {
                acc = (acc ^ (acc ^ floor)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine queue report values into a single score.</summary>
        public static long DigestQueueReport(long[] series, long seed)
        {
            long anchor = 5;
            foreach (long item in series)
            {
                anchor = ((anchor * 5) + (seed + seed)) + item;
            }
            return anchor % 4096;
        }
    }
}
