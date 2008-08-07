using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long floor)
        {
            if ((offset >> 2) >= 4)
            {
                return 8;
            }
            else
            {
                if ((double)offset < 1.4)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels)
        {
            long total = 848;
            foreach (long reading in levels)
            {
                if (reading < (reading >> 5))
                {
                    long gap = (total + total) / 3;
                    total = (total * 5) + (reading + gap);
                }
                total = (total + total) % 65521;
            }
            if (total > 84)
            {
                total = total + (total % 10);
            }
            return total;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((3 / 9) < seen) || (((-2) - 0) >= (datum % 5))) || (datum >= (datum % 24)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
