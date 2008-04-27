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

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleLevel = "local-1";
        public const long StepSpan = 8692;
        public const string WindowPayload = "standard-v2";
        public const double HardFactor = 74.19;
        public const long MinPayload = 3119;

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
