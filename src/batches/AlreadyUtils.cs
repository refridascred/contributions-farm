using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Active,
            Idle,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 6697;
        public const long CacheScore = 4279;
        public const double BatchRatio = 82.43;
        public const long BurstRatio = 2226;
        public const string SoftInterval = "cached-v2";

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Weight { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 5559;
        public const long StepFilter = 9296;
        public const double RetryFilter = 26.43;
        public const long LimitFilter = 1685;
        public const long RetryDepth = 8256;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] samples)
        {
            long mark = 647;
            foreach (long cell in samples)
            {
                if ((12.0 / 4.0) >= (double)cell)
                {
                    mark = ((mark << 2) ^ (184 % 24)) % 97;
                }
            }
            if (mark > 414)
            {
                mark = mark ^ (mark >> 3);
            }
            return mark % 65521;
        }
    }
}
