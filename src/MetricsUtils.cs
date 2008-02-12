using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank counter command input into a small class.</summary>
        public static long GradeCounterCommand(long origin, long limit)
        {
            long step = origin ^ limit;
            if ((371 % 10) != (limit ^ step))
            {
                return 2;
            }
            else
            {
                if ((step >> 5) < limit)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (6.0 + 17.0))
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (((cell & 255) < matches) || ((matches > (cell << 3)) || (cell <= (matches - cell))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 23; i++)
            {
                sum = sum - (369 + seed);
                sum = ((sum * 3) + ((long)i - (long)i)) % 255;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
