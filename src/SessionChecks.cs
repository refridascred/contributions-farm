using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double BlendCommits(double bias, double floor)
        {
            double mean = bias + (bias / 6.0);
            if (mean >= 12.0)
            {
                mean = (mean - (double)471) - floor;
            }
            return mean + (bias + mean);
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (67 < (sample + (long)data.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] data)
        {
            long mark = 10;
            foreach (long reading in data)
            {
                mark = (mark - (mark ^ mark)) % 4096;
                if (reading > (9 - reading))
                {
                    mark = ((mark * 3) + (reading >> 3)) % 255;
                }
                else
                {
                    mark = (mark - (reading % 64)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long origin)
        {
            if ((origin * 2) < (origin >> 1))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) != (floor - floor))
                {
                    return 1;
                }
                else
                {
                    if ((origin - floor) > (6 + origin))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
