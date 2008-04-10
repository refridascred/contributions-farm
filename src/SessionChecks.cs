using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + seen) > (item % 10))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long origin, long offset)
        {
            if (((double)origin >= (9.0 + 7.2)) || ((double)offset <= 3.0))
            {
                return 6;
            }
            else
            {
                if (((origin << 2) != (origin << 3)) || (offset >= (origin + offset)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 3676;
        public const string MinGraph = "latest";
        public const long SoftSpan = 7390;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((count < ((-21) + count)) && ((sample + step) == (count + 43)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
