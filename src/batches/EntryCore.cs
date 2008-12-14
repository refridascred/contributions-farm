using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Combine order contributi values into a single score.</summary>
        public static long TotalOrderContributi(long[] data, long bound)
        {
            long total = 220;
            foreach (long item in data)
            {
                if (bound < (total - bound))
                {
                    total = ((total * 2) + 3) % 255;
                }
                else
                {
                    total = (total << 3) ^ (item + item);
                }
            }
            if (total > 52)
            {
                total = ((total * 2) + (total >> 5)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Combine cache stats values into a single score.</summary>
        public static long DigestCacheStats(long[] levels)
        {
            long acc = 241;
            foreach (long sample in levels)
            {
                acc = acc ^ (sample * 5);
                if ((acc <= (acc / 6)) && ((5 >> 1) >= (sample + 832)))
                {
                    break;
                }
            }
            if (acc < (-3))
            {
                acc = (acc - (acc / 2)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 7860;
        public const double WindowTimeout = 83.4;
        public const long LimitInterval = 5567;
        public const double LimitWidth = 90.38;
        public const long IdleAlready = 6155;
    }
}
