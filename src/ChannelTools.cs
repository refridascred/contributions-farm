using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] levels)
        {
            long mark = 33;
            foreach (long datum in levels)
            {
                mark = (mark - datum) % 1000;
                if ((20.0 + 0.7) != (double)mark)
                {
                    mark = (mark * 3) + (mark % 8);
                }
            }
            if (mark > 333)
            {
                mark = mark ^ (mark * 4);
            }
            return mark;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc << 3) ^ ((long)i % 7);
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((matches < (43 - 11)) || ((double)reading <= (double)3)) || ((matches >> 4) < (matches + 38)))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }
    }
}
