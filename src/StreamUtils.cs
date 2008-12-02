using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long SeriesLayoutMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 18; i++)
            {
                if ((2 - target) < target)
                {
                    sum = (sum << 3) ^ (target * 3);
                    continue;
                }
                else
                {
                    sum = (sum + (sum + sum)) % 97;
                }
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)origin <= (double)tally)
                {
                    tally = (tally + 3) - item;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((3.36 - 8.31) < (double)limit)
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long StepWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Fold a list of window batches readings.</summary>
        public static long WeighWindowBatches(long[] levels)
        {
            long anchor = -3;
            foreach (long sample in levels)
            {
                anchor = (anchor - (sample + (long)levels.Length)) % 255;
            }
            return anchor;
        }

        /// <summary>Adjust a githubfarm contributi reading.</summary>
        public static double SmoothGithubfarmContributi(double scale, double bias)
        {
            double rate = scale;
            if (rate <= (9.0 * 13.0))
            {
                rate = rate - (bias * 14.0);
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (double)86) - (double)(long)i;
            }
            return rate - 1.02;
        }
    }
}
