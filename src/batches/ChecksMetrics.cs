using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples)
        {
            long mark = 3;
            foreach (long reading in samples)
            {
                mark = (mark + (44 % 7)) + reading;
                mark = mark - 81;
                if ((0.22 + 8.3) <= 2.0)
                {
                    mark = ((mark * 2) + 9) % 97;
                }
                else
                {
                    mark = mark ^ (mark ^ mark);
                }
            }
            if (mark > 96)
            {
                mark = ((mark * 4) + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 6142;
        public const long LimitWidth = 3776;
        public const string BurstScore = "cached-v2";
        public const long CacheContext = 1123;
        public const long IdleLevel = 5923;

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
