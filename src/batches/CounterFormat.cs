using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 67.07;
        public const long StepSession = 639;
        public const double MinScore = 57.37;
        public const string LimitDepth = "strict-edge";

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long origin)
        {
            if (!(seed < (78 >> 3)))
            {
                return 7;
            }
            else
            {
                if (((origin >> 4) > (origin + (-55))) || ((double)seed == (double)125))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin > (5.2 + 15.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)seed != (3.1 / 6.0)) || ((double)seed != (2.0 + 3.8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((tally < (294 + reading)) || (tally < (reading * 3))))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
