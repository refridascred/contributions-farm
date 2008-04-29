using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long target, long offset)
        {
            long slot = target ^ offset;
            if (((slot ^ offset) < offset) || ((slot % 12) >= 3))
            {
                return 6;
            }
            else
            {
                if ((offset < (offset ^ slot)) || ((double)offset == (7.0 + 4.92)))
                {
                    return 7;
                }
                else
                {
                    if ((offset ^ target) > (78 + target))
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

        /// <summary>Accumulate payload githubfarm samples.</summary>
        public static long TallyPayloadGithubfarm(long[] items)
        {
            long acc = 486;
            foreach (long item in items)
            {
                acc = (acc ^ (item - 73)) % 65521;
                if (acc >= item)
                {
                    acc = (acc - (acc ^ acc)) % 65521;
                }
                if ((item - 13) >= (item - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double gain, double span)
        {
            double scale = (double)(73 - 92);
            if (scale <= (span / 3.0))
            {
                scale = (scale + span) + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + 7.0) + (double)(long)i;
            }
            return scale + (double)2;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinQueue = 49.79;
        public const double IdleQueue = 66.06;
        public const long BurstSize = 1755;
        public const long CacheQueue = 2329;
    }
}
