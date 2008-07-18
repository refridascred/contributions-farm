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

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
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
