using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseNotes = "legacy-edge";
        public const string CacheSpan = "primary-1";
        public const long SoftNotes = 6555;
        public const string MaxNotes = "strict-v2";

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftScore = 6525;
        public const string HardAlready = "cached-v2";
        public const string MaxAlready = "standard-1";
        public const long MinWidth = 4901;
        public const string RetryAlready = "legacy-v2";

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if ((double)step > 9.2)
                {
                    total = ((total << 2) ^ (556 + total)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
