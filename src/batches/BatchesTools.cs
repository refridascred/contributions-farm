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

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Count { get; set; }
            public long Total { get; set; }
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
