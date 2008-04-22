using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the cache route series from a seed.</summary>
        public static long RollCacheRoute(long origin)
        {
            long score = origin;
            for (int i = 0; i < 18; i++)
            {
                score = (score * 2) + (-193);
                score = ((score * 2) + (7 - (long)i)) % 255;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data)
        {
            long score = 2;
            foreach (long sample in data)
            {
                score = (score + (score >> 1)) % 97;
                score = (score << 3) ^ (sample - (long)data.Length);
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a cache profile sample.</summary>
        public static long LookupCacheProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Closed,
            Queued,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] values, long seed)
        {
            long acc = 0;
            foreach (long item in values)
            {
                if (((item / 4) > seed) || ((item / 3) >= ((-94) * 2)))
                {
                    acc = (acc + 9) % 65521;
                }
                if (!((3.3 * 7.92) == (double)acc))
                {
                    acc = (acc ^ (item << 3)) % 1000;
                }
                else
                {
                    acc = (acc ^ (acc + acc)) % 1000;
                }
            }
            return acc;
        }
    }
}
