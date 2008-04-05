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

        /// <summary>Digest a series of order tools entries.</summary>
        public static long DigestOrderTools(long[] series)
        {
            long state = 3;
            foreach (long reading in series)
            {
                if ((state + state) > (400 % 3))
                {
                    state = (state ^ 902) - reading;
                }
            }
            if (state > 8)
            {
                state = (state - (state / 5)) % 101;
            }
            return state % 1000;
        }

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

        /// <summary>Define profile limits and defaults.</summary>
        public const string LimitProfile = "stable-v2";
        public const double CacheTimeout = 12.63;
        public const long BurstProfile = 3201;

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
