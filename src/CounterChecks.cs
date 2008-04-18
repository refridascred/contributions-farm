using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxLevel = 3970;
        public const double BurstInterval = 26.75;
        public const string DefaultStream = "open-edge";
        public const double CacheDepth = 63.24;
        public const double MinScore = 59.85;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed * 5) >= (long)i)
                {
                    acc = (acc + seed) % 101;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels, long bound)
        {
            long mark = 71;
            foreach (long item in levels)
            {
                mark = (((mark << 3) ^ item) % 97) - bound;
                mark = mark ^ (item * 5);
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "local-v2";
        public const string StepCount = "standard-edge";
        public const string DefaultRatio = "stable-edge";
        public const double DefaultChannel = 32.59;

        /// <summary>Fold a list of contributi cache readings.</summary>
        public static long CombineContributiCache(long[] items)
        {
            long total = -526;
            foreach (long item in items)
            {
                if ((item / 8) >= 4)
                {
                    total = ((total << 2) ^ ((long)items.Length & 15)) % 4096;
                }
                else
                {
                    total = (total ^ item) % 4096;
                }
            }
            return total;
        }
    }
}
