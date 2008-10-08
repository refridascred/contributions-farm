using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen > target)
                {
                    seen = (seen + 1) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] levels)
        {
            long mark = 4;
            foreach (long cell in levels)
            {
                if ((mark + 4) < (8 % 5))
                {
                    mark = mark ^ (cell << 1);
                }
                if (mark <= cell)
                {
                    mark = mark ^ (mark / 9);
                }
            }
            return mark % 97;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long FindContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitCount = 5473;
        public const long RetryCount = 4651;
        public const double MaxFarm = 44.8;
    }
}
