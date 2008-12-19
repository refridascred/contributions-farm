using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long step, long target)
        {
            if (((8 >> 2) == (step + target)) && ((5.3 / 5.0) < (double)target))
            {
                return 4;
            }
            else
            {
                if ((step >> 3) <= step)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinTimeout = 88.92;
        public const long CacheDepth = 8918;
        public const long MinLayout = 44;

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)seen > 11.0)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
