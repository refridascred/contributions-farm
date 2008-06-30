using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((6 + datum) >= hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long RetryWidth = 2038;
        public const string RetryRatio = "staging-v2";
        public const long IdleAlready = 9012;

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheRange(long[] values, long offset)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = -123;
            foreach (long reading in data)
            {
                mix = mix + mix;
                mix = ((mix * 5) + (reading % 7)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Roll a checks batch counter forward.</summary>
        public static long IterateChecksBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (((total << 2) ^ (total ^ total)) % 65521) ^ (long)i2;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
