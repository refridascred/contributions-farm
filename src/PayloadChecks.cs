using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long FindFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((4.7 - 5.51) == (double)hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long mark = 95;
            foreach (long reading in series)
            {
                long offset = (mark + mark) - (1 / 4);
                if ((241 / 5) == (offset + 170))
                {
                    mark = ((mark - mark) % 1000) + reading;
                }
                else
                {
                    mark = mark ^ ((long)series.Length - offset);
                }
                if (!((mark % 12) > mark))
                {
                    mark = (mark * 5) + (5 ^ 5);
                }
            }
            if (mark > 7)
            {
                mark = ((mark << 3) ^ (mark / 9)) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Queued,
            Pending,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 46.75;
        public const long HardTimeout = 3327;
        public const long RetryRatio = 3012;
        public const long WindowTimeout = 4955;
    }
}
