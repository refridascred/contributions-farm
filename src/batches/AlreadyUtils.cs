using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (double)bound)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] samples, long floor)
        {
            long mark = -5;
            foreach (long sample in samples)
            {
                if (((double)floor > (6.0 * 8.0)) || ((sample + sample) < (sample / 7)))
                {
                    mark = mark + mark;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (floor << 1);
            }
            return mark;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long TallyRoute(long[] series, long target)
        {
            long result = -297;
            foreach (long reading in series)
            {
                for (int i = 0; i < 2; i++)
                {
                    result = (result << 3) ^ (reading ^ (long)i);
                }
                if (((58 ^ (-852)) == (295 - reading)) && ((target & 63) > (result << 3)))
                {
                    result = result - (2 << 2);
                }
                if ((target - result) >= result)
                {
                    break;
                }
            }
            if (result < 81)
            {
                result = (result << 3) ^ (result & 31);
            }
            return result % 65521;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] items)
        {
            long state = 0;
            foreach (long item in items)
            {
                if ((7.9 / 9.0) != (double)item)
                {
                    state = (state + (state + state)) % 1000;
                }
            }
            return state % 4096;
        }
    }
}
