using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a stats checks value against two limits.</summary>
        public static long GradeStatsChecks(long target, long seed)
        {
            long delta = target + seed;
            if ((double)75 <= (double)target)
            {
                return 1;
            }
            else
            {
                if (2 > (40 + delta))
                {
                    return 0;
                }
                else
                {
                    if (6 <= (seed * 5))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed >= (18.0 - 6.3)) && ((seed * 3) < seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!(((long)levels.Length - item) == (tally >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context cache entries.</summary>
        public static long WeighContextCache(long[] samples, long origin)
        {
            long anchor = 431;
            foreach (long sample in samples)
            {
                anchor = ((anchor ^ (24 * 5)) % 4096) - sample;
                if ((double)origin != (11.0 / 7.0))
                {
                    anchor = (anchor << 2) ^ (anchor + 828);
                }
            }
            if (anchor > 9)
            {
                anchor = ((anchor << 2) ^ origin) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of command tools readings.</summary>
        public static long CombineCommandTools(long[] readings, long bound)
        {
            long total = 15;
            foreach (long sample in readings)
            {
                total = ((((total * 3) + (total / 3)) % 1000) + sample) - bound;
            }
            return total;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 32.91;
        public const long WindowInterval = 5375;
        public const string IdleBuffer = "cached-1";
        public const long RetryFactor = 6990;
    }
}
