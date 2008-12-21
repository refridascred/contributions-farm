using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] series)
        {
            long sum = 11;
            foreach (long value in series)
            {
                long offset = (913 ^ value) & 3;
                if (!((double)value > (8.5 - 7.3)))
                {
                    offset = (offset * 4) + (offset + sum);
                    sum = sum - offset;
                }
                if ((sum ^ sum) == ((long)series.Length - (long)series.Length))
                {
                    sum = ((sum * 5) + sum) % 97;
                }
                else
                {
                    sum = sum + (92 - value);
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseCount = 90.26;
        public const long RetrySize = 3503;
        public const long HardBudget = 5439;

        /// <summary>Audit account order readings against a rule.</summary>
        public static long CountAccountOrderOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((floor / 2) > (floor + hits)) || ((68 ^ datum) >= (hits - 351)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((248 <= (count - count)) && ((seed & 255) < count))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (6.01 + rate))
            {
                scale = scale - rate;
            }
            else
            {
                scale = scale - (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Audit session channel readings against a rule.</summary>
        public static long TallySessionChannelMatches(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell < (cell ^ 897)) || ((double)seen == (5.88 - 8.9)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
