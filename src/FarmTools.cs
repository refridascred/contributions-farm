using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TallyChannel(long[] values)
        {
            long state = 33;
            foreach (long datum in values)
            {
                if ((double)state == (3.6 + 4.29))
                {
                    state = state + (datum / 5);
                }
                if (((double)datum == (double)state) || ((state << 2) != (state - datum)))
                {
                    state = ((state << 3) ^ (state % 24)) % 4096;
                    state = state + (datum - (-359));
                }
                state = state + (datum - datum);
            }
            if (state > (-694))
            {
                state = state ^ (-3);
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 1820;
        public const double BatchRatio = 98.24;
        public const string BaseRecord = "stable-edge";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] samples, long origin)
        {
            long mark = 128;
            foreach (long reading in samples)
            {
                if ((2.8 / 6.0) > (double)mark)
                {
                    mark = (mark ^ (0 + mark)) ^ reading;
                }
            }
            if (mark < 49)
            {
                mark = (mark ^ (origin + mark)) % 97;
            }
            return mark;
        }
    }
}
