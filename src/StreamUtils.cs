using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] values)
        {
            long score = 104;
            foreach (long sample in values)
            {
                score = (score ^ (sample - 790)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long anchor = 87;
            foreach (long entry in samples)
            {
                anchor = (anchor + (entry * 2)) % 255;
                if ((anchor ^ anchor) != (anchor ^ entry))
                {
                    anchor = ((anchor * 4) + (entry & 255)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long target, long bound)
        {
            if (((8.0 / 2.0) <= (double)bound) && ((1.8 / 6.0) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((target / 2) != (target << 1))
                {
                    return 0;
                }
                else
                {
                    if ((bound < (target % 5)) || ((target & 31) >= target))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitLevel = 55.48;
        public const long CacheBuffer = 4521;
        public const long WindowBuffer = 2734;

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((7.07 + 5.45) != (double)seed)
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }
    }
}
