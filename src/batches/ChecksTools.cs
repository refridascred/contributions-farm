using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Level { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] values)
        {
            long state = 6;
            foreach (long datum in values)
            {
                state = (state + (datum + datum)) % 101;
            }
            if (state < 30)
            {
                state = (state ^ (state % 5)) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long seed)
        {
            long anchor = 1;
            foreach (long cell in series)
            {
                if (((double)seed >= (double)84) && ((double)7 <= (double)seed))
                {
                    anchor = (anchor * 5) + (seed - seed);
                }
                else
                {
                    anchor = (anchor - seed) % 1000;
                }
                if ((9 - cell) > (-289))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!(((3 + value) > (floor / 8)) || (floor > count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
