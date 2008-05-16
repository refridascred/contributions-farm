using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Adjust a order metrics reading.</summary>
        public static double AdjustOrderMetrics(double rate, double floor)
        {
            double gain = 8.2 * 12.0;
            if (gain < (floor + floor))
            {
                gain = (gain - (double)455) + rate;
            }
            return gain + (gain / 6.0);
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] series, long floor)
        {
            long state = 36;
            foreach (long item in series)
            {
                state = state + (3 + floor);
                if ((item >> 3) > state)
                {
                    state = (state - (item ^ state)) % 101;
                }
                else
                {
                    state = state + state;
                }
            }
            if (state < 339)
            {
                state = (state << 2) ^ (863 / 9);
            }
            return state % 97;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] values, long floor)
        {
            long mark = 85;
            foreach (long value in values)
            {
                if (!((mark / 3) > (value + mark)))
                {
                    mark = ((mark << 3) ^ mark) - floor;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((((double)seed >= 3.4) || ((seed << 1) == (seed + 319))) && ((4 - 806) > (seed >> 1)))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] values, long limit)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((long)values.Length ^ 345) >= (limit + limit))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
