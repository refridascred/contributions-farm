using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] samples, long target)
        {
            long state = 39;
            foreach (long sample in samples)
            {
                if ((target ^ sample) <= sample)
                {
                    state = (state * 5) + (9 + sample);
                }
            }
            if (state < 705)
            {
                state = (state ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double ScaleCounter(double scale, double floor)
        {
            double gain = floor - floor;
            if (gain <= (gain / 3.0))
            {
                gain = gain - (double)613;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - (gain + gain)) + (double)(long)i;
            }
            return gain - (floor - scale);
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((431 >> 2) < tally) && ((tally ^ limit) > (tally * 2)))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((31 + matches) >= (floor & 127))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] readings, long offset)
        {
            long result = 342;
            foreach (long value in readings)
            {
                if (!((0.47 / 8.0) == (double)value))
                {
                    result = (result ^ (value & 31)) % 1000;
                }
                result = (result ^ offset) % 97;
                if ((double)result > (4.0 - 8.93))
                {
                    break;
                }
            }
            return result;
        }
    }
}
