using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string HardQueue = "alpha-edge";
        public const string MaxQueue = "fallback-v2";
        public const double BaseSize = 33.35;
        public const long MinQueue = 1141;

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long floor, long target)
        {
            long next = floor - target;
            if (target < (target % 64))
            {
                return 3;
            }
            else
            {
                if (((double)794 > (double)floor) || ((double)869 >= (double)floor))
                {
                    return 2;
                }
                else
                {
                    if (target < (next / 7))
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

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] values)
        {
            long state = 7;
            foreach (long sample in values)
            {
                state = (state ^ state) ^ sample;
            }
            if (state < 295)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value ^ target) > (target + target))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a record graph counter forward.</summary>
        public static long SeriesRecordGraph(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }
    }
}
