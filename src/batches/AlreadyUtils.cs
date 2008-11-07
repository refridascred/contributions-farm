using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((630 - floor) <= (floor - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings, long limit)
        {
            long mark = 7;
            foreach (long item in readings)
            {
                mark = (mark + mark) % 97;
                mark = ((mark << 3) ^ (mark + item)) % 65521;
                if (limit >= (limit * 3))
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long step)
        {
            long gap = origin + step;
            if ((step & 15) <= (gap ^ gap))
            {
                return 2;
            }
            else
            {
                if (((7.9 / 9.0) <= (double)origin) || (gap <= step))
                {
                    return 3;
                }
                else
                {
                    if ((origin - origin) != (origin + gap))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Look up the position of a cache metric sample.</summary>
        public static long SeekCacheMetricIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
