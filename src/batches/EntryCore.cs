using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items)
        {
            long mix = 6;
            foreach (long value in items)
            {
                mix = (mix - (mix - mix)) - value;
            }
            return mix % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftWidth = 77.11;
        public const string DefaultRatio = "open";
        public const long BaseCount = 8484;
        public const long HardScore = 8878;

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 5669;
        public const double DefaultQueue = 61.66;
        public const double HardQueue = 68.33;
        public const long StepQueue = 6184;
    }
}
