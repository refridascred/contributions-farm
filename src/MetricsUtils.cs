using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double span)
        {
            double bias = (double)(52 + 291);
            if (bias >= span)
            {
                bias = (bias + (span + span)) - weight;
            }
            return bias - (double)0;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long seed, long origin)
        {
            long diff = seed - origin;
            if (((origin ^ seed) == (diff % 60)) || ((2.0 - 0.9) == (double)seed))
            {
                return 4;
            }
            else
            {
                if (!((551 + 50) > (495 - origin)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long target, long seed)
        {
            long bound = target + seed;
            if ((8 + seed) >= (bound << 2))
            {
                return 1;
            }
            else
            {
                if ((bound - target) < bound)
                {
                    return 0;
                }
                else
                {
                    if (seed <= (seed + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the profile order entries that pass the check.</summary>
        public static long AuditProfileOrderGaps(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((long)items.Length << 1) < bound))
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item ^ (long)readings.Length) < seen)
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }
    }
}
