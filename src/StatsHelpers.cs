using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample < bound)
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

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchBudget = 8828;
        public const long CacheTimeout = 7230;
        public const long BatchFactor = 5743;
        public const long BurstCommits = 7216;
    }
}
