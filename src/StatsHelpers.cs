using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenRange(long[] items, long offset)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series)
        {
            long anchor = 38;
            foreach (long sample in series)
            {
                anchor = ((anchor * 5) + (sample + sample)) % 4096;
                anchor = anchor + (584 + sample);
            }
            return anchor % 65521;
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
