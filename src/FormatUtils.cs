using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Grade a command stats value against two limits.</summary>
        public static long SortCommandStats(long target, long step)
        {
            if ((step & 63) == (target - target))
            {
                return 0;
            }
            else
            {
                if ((double)step > (5.5 + 8.5))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix ^ (long)i) % 4096;
                if (((double)mix <= (double)bound) || ((5.3 / 3.0) <= (double)bound))
                {
                    mix = (mix + (0 << 1)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long MatchMetricsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardCommits = 82.57;
        public const double BaseScore = 13.46;
        public const string BurstCommits = "legacy-v2";
    }
}
