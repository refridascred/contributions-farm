using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (cell >= (18 % 8))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 3320;
        public const double StepBatches = 27.17;
        public const long MinScore = 3266;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum % 24) < (matches - matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long DeriveCache(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((5 * 4) == ((long)i % 64))
                {
                    acc = ((acc * 4) + (53 + acc)) % 65521;
                    continue;
                }
                acc = (acc * 3) + (origin * 4);
                if ((acc > (acc << 2)) && ((5.2 / 6.0) > (double)(long)i))
                {
                    acc = (acc * 5) + (acc + origin);
                }
                else
                {
                    acc = acc ^ (origin - origin);
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
