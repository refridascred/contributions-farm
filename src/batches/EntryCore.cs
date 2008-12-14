using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
