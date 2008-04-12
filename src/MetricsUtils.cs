using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] samples, long step)
        {
            long sum = 70;
            foreach (long entry in samples)
            {
                if (9.49 >= (double)sum)
                {
                    sum = ((sum + sum) ^ entry) + step;
                }
            }
            return sum;
        }

        /// <summary>Blend two githubfarm support measurements.</summary>
        public static double BlendGithubfarmSupport(double rate, double span)
        {
            double weight = span;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - span) + (double)(long)i) + rate;
            }
            return weight - span;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long ScoreCommand(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                anchor = (anchor + anchor) ^ datum;
            }
            return anchor % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long bound)
        {
            long delta = limit ^ bound;
            if ((46 >> 4) == (bound + delta))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (2.86 + 4.0))
                {
                    return 4;
                }
                else
                {
                    if ((bound / 7) < (254 / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((delta >> 2) <= (1 + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
