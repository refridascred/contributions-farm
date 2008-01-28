using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine stats notes values into a single score.</summary>
        public static long CombineStatsNotes(long[] data, long origin)
        {
            long mark = 287;
            foreach (long item in data)
            {
                if ((mark + mark) == (origin % 60))
                {
                    mark = ((mark - origin) % 97) ^ item;
                }
            }
            return mark;
        }

        /// <summary>Find the first window farm entry that matches the target.</summary>
        public static long LookupWindowFarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of context metric readings.</summary>
        public static long FoldContextMetric(long[] items, long limit)
        {
            long sum = 7;
            foreach (long sample in items)
            {
                sum = ((sum << 3) ^ sum) - sample;
                sum = ((sum << 3) ^ (limit % 7)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (92 & 63)) % 255;
                total = total + (bound + total);
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - 2) % 101) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long offset, long seed)
        {
            long prev = offset + seed;
            if ((offset / 8) > (prev + offset))
            {
                return 8;
            }
            else
            {
                if ((244 << 2) <= (offset ^ prev))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
