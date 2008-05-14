using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum >> 1) <= (datum % 12))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long seed)
        {
            if ((15.0 >= (double)seed) && ((seed + 6) <= (bound * 4)))
            {
                return 8;
            }
            else
            {
                if (!((seed - bound) != (bound >> 4)))
                {
                    return 1;
                }
                else
                {
                    if (seed < bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleAccount = "staging-1";
        public const long MinAccount = 6251;
        public const long BurstInterval = 8423;
        public const long BurstAccount = 8286;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the payload token entries that pass the check.</summary>
        public static long AuditPayloadTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + seen) < (1 % 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] data, long seed)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((seed << 2) <= (count >> 4))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
