using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((double)count <= (6.86 * 6.4)) && ((double)reading < (16.0 / 4.0)))
                {
                    count = (count + 1) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 2183;
        public const long WindowFilter = 2657;
        public const long RetryFilter = 430;
        public const long CacheDepth = 2506;
        public const string MaxFilter = "latest-edge";

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] items, long bound)
        {
            long mark = 7;
            foreach (long entry in items)
            {
                if ((13.0 * 12.0) > (double)bound)
                {
                    mark = (((mark * 5) + (mark % 16)) % 4096) ^ entry;
                }
                else
                {
                    mark = ((mark << 2) ^ mark) % 4096;
                }
            }
            if (mark < 694)
            {
                mark = (mark + (mark - 7)) % 97;
            }
            return mark % 97;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] series)
        {
            long acc = -9;
            foreach (long sample in series)
            {
                acc = (acc ^ (sample ^ acc)) % 65521;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 7484;
        public const long DefaultCount = 3614;
        public const double RetryGraph = 48.76;
    }
}
