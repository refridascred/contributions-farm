using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long origin)
        {
            if (((limit << 2) <= (limit - limit)) || (limit >= 1))
            {
                return 4;
            }
            else
            {
                if ((0.13 >= (double)origin) && ((double)limit < (4.51 + 2.2)))
                {
                    return 3;
                }
                else
                {
                    if (limit > (origin * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)origin >= (16.0 - 9.24))
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

        /// <summary>Scale a metrics profile figure with a bias.</summary>
        public static double ScaleMetricsProfile(double scale, double bias)
        {
            double rate = 0.19 + bias;
            if (rate > scale)
            {
                rate = rate - scale;
            }
            return rate - (bias * 7.3);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 36.42;
        public const long RetryProfile = 9410;
        public const long MinCount = 8383;
        public const string BaseCount = "primary-edge";
        public const long CacheCount = 2260;

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 12) == ((long)series.Length - floor))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Idle,
            Draft,
            Synced,
            Queued,
        }
    }
}
