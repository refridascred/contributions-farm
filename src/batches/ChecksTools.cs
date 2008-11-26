using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a profile command value against two limits.</summary>
        public static long RankProfileCommand(long bound, long step)
        {
            long lane = bound ^ step;
            if ((2 + lane) == (bound % 24))
            {
                return 1;
            }
            else
            {
                if ((step + lane) >= (lane / 2))
                {
                    return 8;
                }
                else
                {
                    if (((double)bound != (6.0 + 7.59)) && (step >= bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine route session values into a single score.</summary>
        public static long ScoreRouteSession(long[] samples, long step)
        {
            long acc = 3;
            foreach (long value in samples)
            {
                if ((540 % 16) <= value)
                {
                    acc = (acc - (step + value)) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (512 * 4)) % 1000;
                }
            }
            if (acc < 852)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamOutliers(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (entry > (limit / 5))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double bias, double span)
        {
            double drift = (6.9 - 1.3) + bias;
            if (drift > bias)
            {
                drift = (drift + (drift + 10.0)) - span;
            }
            else
            {
                drift = drift - bias;
            }
            return drift + drift;
        }
    }
}
