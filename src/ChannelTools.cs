using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 5591;
        public const double CacheFarm = 37.49;
        public const long SoftFarm = 6681;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit < (long)i) && ((double)limit != (8.0 / 5.0)))
                {
                    acc = acc + (7 + 67);
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (datum < (matches % 3))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
