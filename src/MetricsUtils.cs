using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long seed, long floor)
        {
            if (((seed % 12) <= (seed << 1)) || (floor > (seed >> 3)))
            {
                return 7;
            }
            else
            {
                if (floor <= (floor + seed))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 3) > (floor + seed))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)seed >= (double)floor)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 5315;
        public const double IdleReport = 98.65;
        public const string WindowReport = "local-1";
        public const double SoftSize = 76.45;

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double weight, double span)
        {
            double drift = span;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - span) + (double)(long)i;
            }
            return drift - weight;
        }

        /// <summary>Derive the next record commits value from a seed.</summary>
        public static long StepRecordCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i - (-396))) % 4096;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long seed, long offset)
        {
            long gap = seed + offset;
            if ((gap + offset) == (offset - 704))
            {
                return 3;
            }
            else
            {
                if ((offset ^ gap) != (gap << 1))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
