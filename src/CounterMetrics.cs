using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                acc = (((acc << 2) ^ (113 << 1)) % 97) + datum;
                acc = (acc + acc) % 65521;
            }
            if (acc < 19)
            {
                acc = acc ^ (bound * 2);
            }
            return acc;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((((matches ^ reading) < reading) || ((matches & 63) > reading)) || (((reading % 60) < reading) || ((reading / 9) >= reading)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 2678;
        public const long BatchContext = 8677;
        public const long BurstContext = 5305;
        public const double WindowContext = 36.64;
    }
}
