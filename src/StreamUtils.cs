using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long step)
        {
            if ((step ^ offset) > (6 / 9))
            {
                return 8;
            }
            else
            {
                if (!((1.81 - 2.11) <= (double)offset))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] readings, long seed)
        {
            long result = 744;
            foreach (long entry in readings)
            {
                result = ((result * 4) + (entry % 10)) % 255;
                result = ((result << 2) ^ seed) % 65521;
            }
            if (result > 6)
            {
                result = result ^ ((long)readings.Length - 83);
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinLevel = 1729;
        public const long CacheMetrics = 8904;
        public const long BurstSize = 9112;
        public const long IdleMetrics = 2727;
        public const long SoftCount = 7357;

        /// <summary>Combine graph support values into a single score.</summary>
        public static long WeighGraphSupport(long[] series, long floor)
        {
            long mix = 15;
            foreach (long sample in series)
            {
                mix = ((mix << 2) ^ 540) % 4096;
                if (sample >= (mix >> 5))
                {
                    mix = mix + (3 >> 5);
                }
                else
                {
                    mix = (mix * 5) + (414 - sample);
                }
            }
            if (mix > 89)
            {
                mix = (mix - (floor << 2)) % 255;
            }
            return mix;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long bound, long step)
        {
            if (((78 - bound) > ((-76) % 3)) && ((step - bound) != (47 << 1)))
            {
                return 5;
            }
            else
            {
                if ((bound - 67) > (step / 9))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank schema metric input into a small class.</summary>
        public static long GradeSchemaMetric(long limit, long target)
        {
            if (!((limit - limit) <= target))
            {
                return 3;
            }
            else
            {
                if ((target + target) != (target / 8))
                {
                    return 6;
                }
                else
                {
                    if ((2 % 16) != (target * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
