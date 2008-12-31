using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long WeighChecks(long[] series)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if ((mark & 31) <= (mark << 1))
                {
                    long hits = mark + (mark + mark);
                    mark = mark ^ hits;
                }
                if ((item - mark) != (714 >> 3))
                {
                    mark = (mark + (item - mark)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long RollSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((3.7 * 7.0) != (double)acc)
                {
                    acc = (acc + acc) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 6006;
        public const long SoftWidth = 9659;
        public const double IdleRecord = 44.73;

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowProfile = "staging-v2";
        public const long DefaultProfile = 3981;
        public const long StepProfile = 2043;
        public const long MinSize = 2758;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((hits & 15) == (datum - limit))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
