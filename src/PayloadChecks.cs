using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((4.8 * 14.0) != (double)tally)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long limit, long target)
        {
            long span = limit - target;
            if ((double)limit != (8.3 / 2.0))
            {
                return 8;
            }
            else
            {
                if ((6.4 - 6.32) > (double)span)
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit > (double)target)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mark = -33;
            foreach (long item in levels)
            {
                if (((486 ^ origin) < origin) || ((item - mark) != (6 % 8)))
                {
                    mark = ((mark << 3) ^ (mark + origin)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitGithubfarm = 8358;
        public const long MinGithubfarm = 8065;
        public const string SoftSize = "local-v2";

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (((seed & 7) > (mix - seed)) || ((double)mix < (5.76 + 6.0)))
                {
                    break;
                }
                else
                {
                    mix = mix - 10;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many support route samples are out of range.</summary>
        public static long CountSupportRouteHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (!((item > (hits % 5)) && ((hits % 10) > (item + 14))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
