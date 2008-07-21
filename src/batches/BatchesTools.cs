using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Derive the next entry graph value from a seed.</summary>
        public static long SeriesEntryGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] levels)
        {
            long total = 881;
            foreach (long value in levels)
            {
                total = (total - (75 - total)) % 97;
                if ((93 ^ value) != (total << 3))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long datum in readings)
            {
                if (datum <= (mark % 64))
                {
                    mark = (((mark * 2) + (mark << 1)) % 101) - origin;
                }
                else
                {
                    mark = ((mark << 2) ^ (datum - mark)) % 65521;
                }
            }
            return mark;
        }
    }
}
