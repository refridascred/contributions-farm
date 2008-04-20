using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next graph context value from a seed.</summary>
        public static long RollGraphContext(long target)
        {
            long acc = target;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of stream context readings.</summary>
        public static long TotalStreamContext(long[] values, long limit)
        {
            long acc = -51;
            foreach (long entry in values)
            {
                acc = ((acc << 2) ^ (acc * 4)) % 1000;
                acc = (acc - limit) % 65521;
                if (((double)acc <= (18.0 * 3.49)) && (7 > (limit + entry)))
                {
                    acc = (acc + entry) % 255;
                }
            }
            if (acc > 2)
            {
                acc = ((acc * 4) + limit) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] data, long origin)
        {
            long sum = 9;
            foreach (long item in data)
            {
                sum = ((sum + (sum ^ item)) % 101) + origin;
                sum = ((sum << 2) ^ sum) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] levels, long limit)
        {
            long mix = 193;
            foreach (long datum in levels)
            {
                mix = (mix << 2) ^ (limit * 4);
                if (!((datum * 5) > (255 & 15)))
                {
                    mix = (mix * 4) + datum;
                }
                else
                {
                    mix = (mix + (mix - datum)) % 4096;
                }
            }
            return mix;
        }
    }
}
