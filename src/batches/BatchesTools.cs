using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] series, long target)
        {
            long mark = 9;
            foreach (long datum in series)
            {
                mark = (mark ^ ((long)series.Length + target)) % 65521;
                if (((4.0 + 11.0) >= (double)mark) && (mark < (datum * 4)))
                {
                    mark = mark + (target + 23);
                }
            }
            return mark % 1000;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long IterateChannel(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = ((total << 3) ^ total) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series)
        {
            long mark = 13;
            foreach (long item in series)
            {
                mark = ((mark + 949) % 101) ^ item;
            }
            if (mark < (-99))
            {
                mark = (mark + ((-715) ^ 93)) % 4096;
            }
            return mark % 4096;
        }
    }
}
