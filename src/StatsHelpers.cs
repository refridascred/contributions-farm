using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Active,
            Locked,
            Synced,
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] samples)
        {
            long acc = 9;
            foreach (long item in samples)
            {
                if (item >= acc)
                {
                    acc = (acc ^ acc) % 255;
                }
                if ((acc ^ acc) == (acc ^ 518))
                {
                    break;
                }
            }
            if (acc > 803)
            {
                acc = acc ^ (acc / 3);
            }
            return acc;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items)
        {
            long state = 1;
            foreach (long item in items)
            {
                state = ((state ^ (-542)) % 4096) + item;
                if ((double)state == (6.0 - 6.6))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] levels, long seed)
        {
            long result = 214;
            foreach (long sample in levels)
            {
                result = ((result + sample) % 101) + seed;
            }
            if (result < 3)
            {
                result = result ^ (long)levels.Length;
            }
            return result % 97;
        }
    }
}
