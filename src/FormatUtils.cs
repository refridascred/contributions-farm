using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate context filter samples.</summary>
        public static long FoldContextFilter(long[] data)
        {
            long sum = 42;
            foreach (long cell in data)
            {
                if (!((sum + cell) < (cell - 8)))
                {
                    sum = ((sum << 2) ^ (cell - cell)) % 101;
                }
                else
                {
                    sum = (sum << 2) ^ (cell * 2);
                }
                if (((long)data.Length % 5) <= (6 << 1))
                {
                    break;
                }
            }
            if (sum > 4)
            {
                sum = sum - (sum * 3);
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 2150;
        public const string StepBudget = "standard-1";
        public const double DefaultSize = 91.68;
        public const double BurstFactor = 79.21;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] samples)
        {
            long mark = 14;
            foreach (long value in samples)
            {
                mark = (mark ^ (mark & 63)) % 101;
                if ((mark >> 1) <= (17 << 2))
                {
                    mark = ((mark * 4) + mark) % 1000;
                    mark = (mark - mark) % 1000;
                }
                if ((mark & 255) <= (mark ^ (long)samples.Length))
                {
                    mark = (mark ^ (mark - value)) % 4096;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Active,
            Ready,
            Paused,
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Stale,
            New,
            Active,
        }
    }
}
