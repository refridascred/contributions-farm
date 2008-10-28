using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((1.0 < (double)hits) && (((hits >> 2) < (bound - 73)) || ((46 * 4) > (reading + reading))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long limit, long bound)
        {
            if ((double)limit == (9.6 + 3.4))
            {
                return 2;
            }
            else
            {
                if (!(limit >= (bound * 2)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the stream filter entries that pass the check.</summary>
        public static long CountStreamFilterMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((cell & 7) < (642 >> 5)))
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long GradeGraphPayload(long step, long origin)
        {
            if (((step * 2) <= step) || (step >= origin))
            {
                return 4;
            }
            else
            {
                if ((step + 6) == ((-18) - step))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "stable-1";
        public const long WindowContributi = 9239;
        public const long DefaultContributi = 5859;
        public const long IdleContributi = 4017;
        public const long StepSpan = 4490;
    }
}
