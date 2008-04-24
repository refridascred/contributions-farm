using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const long IdleCommits = 1864;
        public const long BurstCommits = 6962;
        public const long MaxCommits = 1077;

        /// <summary>Locate a metric format reading by value.</summary>
        public static long LookupMetricFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(349 <= (78 - cell)))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels, long step)
        {
            long mix = 496;
            foreach (long reading in levels)
            {
                if ((double)7 != (double)step)
                {
                    mix = mix ^ (23 - step);
                }
                if (((step & 127) != (mix - step)) || ((reading ^ step) > (48 - step)))
                {
                    mix = (mix ^ (42 / 7)) % 101;
                }
            }
            if (mix < (-218))
            {
                mix = (mix << 2) ^ 897;
            }
            return mix % 65521;
        }
    }
}
