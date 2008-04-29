using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double weight = (double)(-987) - rate;
            if (weight >= (double)74)
            {
                weight = (weight - weight) - bias;
            }
            return weight + (rate * 2.68);
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (((31 - 53) <= (reading - seen)) || ((reading >> 5) < (seen + seen)))
                {
                    seen = (seen + 3) + bound;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepLevel = 2392;
        public const string StepAlready = "open-edge";
        public const long LimitAlready = 1973;
        public const long BurstAlready = 2428;
        public const string SoftSize = "primary-edge";

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long bound, long floor)
        {
            if ((floor - floor) > bound)
            {
                return 2;
            }
            else
            {
                if ((56 - 161) < bound)
                {
                    return 3;
                }
                else
                {
                    if (bound >= (bound + bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 4) >= floor)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a metric editor pair into a bucket.</summary>
        public static long BucketMetricEditor(long bound, long limit)
        {
            if ((4.11 + 8.1) != (double)bound)
            {
                return 2;
            }
            else
            {
                if ((84 >> 5) <= (bound ^ limit))
                {
                    return 7;
                }
                else
                {
                    if (((0.8 + 9.6) < (double)limit) || ((limit & 63) >= limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(limit <= (limit + limit)))
                        {
                            return 3;
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
}
