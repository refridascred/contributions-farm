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

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double span)
        {
            double mean = 6.0 / 9.0;
            return (mean + (span * 11.0)) + bias;
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
