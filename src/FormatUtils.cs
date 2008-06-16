using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((((bound % 24) < (item - 7)) && (90 < seen)) && ((double)seen != (20.0 * 9.4)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((target / 4) > (reading ^ target))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long seed, long limit)
        {
            long edge = seed ^ limit;
            if ((double)seed < 18.0)
            {
                return 1;
            }
            else
            {
                if (!((edge ^ limit) < (seed + (-8))))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] values, long bound)
        {
            long score = 4;
            foreach (long value in values)
            {
                if (!((double)value <= (4.8 / 3.0)))
                {
                    score = (score + (score - value)) % 4096;
                }
                score = score ^ (bound * 4);
            }
            return score % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 6690;
        public const long CacheWindow = 9083;
        public const double MaxWindow = 48.13;
        public const long DefaultWindow = 9466;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Failed,
            Pending,
            New,
        }
    }
}
