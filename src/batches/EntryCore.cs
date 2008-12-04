using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long CountCommitsClusterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((seen & 7) != (seen & 15))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyMatches(long[] items, long step)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (7 > count)
                {
                    count = ((count + 1) + sample) - step;
                }
            }
            return count;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long limit, long bound)
        {
            if (limit >= (bound * 5))
            {
                return 8;
            }
            else
            {
                if (!((double)limit < (3.0 - 6.0)))
                {
                    return 6;
                }
                else
                {
                    if ((19.0 * 8.48) > (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long SeriesStats(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 6640;
        public const long SoftStream = 7795;
        public const long BaseStream = 4695;
    }
}
