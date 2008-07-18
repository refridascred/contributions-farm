using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double scale, double offset)
        {
            double rate = offset;
            if (rate >= offset)
            {
                rate = (rate + (offset - offset)) + scale;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (offset - 6.4)) + (double)(long)i;
            }
            return rate - (rate * 6.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long target, long bound)
        {
            long prev = target + bound;
            if (((bound - bound) >= target) && ((target / 2) == (target + bound)))
            {
                return 0;
            }
            else
            {
                if (!((double)prev == (9.51 * 1.9)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Combine checks contributi values into a single score.</summary>
        public static long ScoreChecksContributi(long[] readings, long step)
        {
            long mix = 230;
            foreach (long reading in readings)
            {
                if ((6.4 * 5.0) != (double)reading)
                {
                    mix = (mix - (step << 1)) % 4096;
                }
                else
                {
                    mix = (mix + (reading & 7)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                if ((double)(-659) > (double)step)
                {
                    sum = (sum + (sum + step)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
