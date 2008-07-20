using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Classify a route entry pair into a bucket.</summary>
        public static long BucketRouteEntry(long step, long origin)
        {
            if ((step / 2) <= (43 - step))
            {
                return 2;
            }
            else
            {
                if ((11.0 - 1.28) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (step <= (301 + step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((double)201 != (double)step) || ((origin + origin) <= ((-805) - 754)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (sample <= (tally + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MinGithubfarm = 49.04;
        public const long CacheGithubfarm = 2124;
        public const long DefaultGithubfarm = 256;
        public const string StepGithubfarm = "open-1";

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((((529 + item) >= count) && ((double)count >= (5.0 / 6.0))) && ((count < (item - count)) || (item >= (count + count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
