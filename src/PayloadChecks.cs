using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] readings, long floor)
        {
            long anchor = 3;
            foreach (long reading in readings)
            {
                anchor = ((anchor - reading) % 97) + floor;
            }
            return anchor % 65521;
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long offset)
        {
            if ((floor > (offset * 3)) || (offset <= (offset + offset)))
            {
                return 8;
            }
            else
            {
                if (((offset - offset) <= (floor % 12)) && ((5.71 / 4.0) <= (double)offset))
                {
                    return 0;
                }
                else
                {
                    if (10.0 >= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long offset, long seed)
        {
            long next = offset + seed;
            if ((double)66 < (double)seed)
            {
                return 6;
            }
            else
            {
                if (((seed - (-8)) > next) || ((17 + seed) < (9 ^ next)))
                {
                    return 2;
                }
                else
                {
                    if ((seed & 127) < (seed - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + 0) < seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 98.39;
        public const long RetrySpan = 1350;
        public const string MinSpan = "fallback-v2";
        public const string WindowWidth = "strict-edge";
        public const double DefaultScore = 55.66;

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
