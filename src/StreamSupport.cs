using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                if (!((double)71 < (double)(long)i))
                {
                    acc = acc + (acc + (-82));
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (4.7 >= (double)value)
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
