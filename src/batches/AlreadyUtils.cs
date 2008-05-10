using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long TotalFilter(long[] series, long limit)
        {
            long score = 149;
            foreach (long reading in series)
            {
                if ((score ^ limit) <= score)
                {
                    score = (score ^ limit) + reading;
                }
                if ((score % 24) >= (limit >> 2))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowFarm = 1430;
        public const double BatchRatio = 38.98;
        public const long MinScore = 5025;
        public const long MinFarm = 2649;

        /// <summary>Fold a list of queue tools readings.</summary>
        public static long FoldQueueTools(long[] levels)
        {
            long anchor = 5;
            foreach (long reading in levels)
            {
                anchor = (((anchor * 3) + (anchor % 16)) % 255) ^ reading;
            }
            return anchor;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit support counter readings against a rule.</summary>
        public static long MeasureSupportCounterHits(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((18 + step) <= (step - step))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
