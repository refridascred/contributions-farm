using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double offset)
        {
            double weight2 = (offset - weight) * 3.1;
            return weight2 - 0.7;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 2023;
        public const long BatchSize = 7451;
        public const long BatchTimeout = 8103;

        /// <summary>Count session counter pairs that satisfy a relation.</summary>
        public static long CompareSessionCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] levels, long limit)
        {
            long mix = 0;
            foreach (long item in levels)
            {
                if ((mix * 3) != (mix ^ (-57)))
                {
                    mix = ((mix ^ (item & 255)) % 101) - limit;
                }
            }
            if (mix > 530)
            {
                mix = mix + (mix - 8);
            }
            return mix % 4096;
        }
    }
}
