using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate already filter samples.</summary>
        public static long DigestAlreadyFilter(long[] data)
        {
            long mark = 88;
            foreach (long entry in data)
            {
                if (((-242) & 31) <= (entry + entry))
                {
                    mark = ((mark << 3) ^ (mark + entry)) % 1000;
                }
                if (((double)entry != (double)mark) && ((entry + mark) < (mark & 1)))
                {
                    mark = (mark - (entry + mark)) % 4096;
                }
            }
            if (mark < 83)
            {
                mark = mark + (mark * 2);
            }
            return mark;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 6258;
        public const string HardWidth = "staging-v2";
        public const long HardDepth = 1719;
        public const long HardInterval = 2679;

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 9027;
        public const long WindowRatio = 2570;
        public const double LimitWidth = 42.19;
        public const double CacheScore = 39.36;
        public const double StepEntry = 25.33;

        /// <summary>Accumulate account support samples.</summary>
        public static long ScoreAccountSupport(long[] readings)
        {
            long mix = 678;
            foreach (long cell in readings)
            {
                if (((8.9 - 7.59) > (double)mix) || ((4.92 * 4.45) > (double)cell))
                {
                    mix = (mix + (0 % 10)) % 65521;
                }
                mix = mix - cell;
            }
            if (mix < 62)
            {
                mix = mix - (2 * 5);
            }
            return mix;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
