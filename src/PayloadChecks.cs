using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinWidth = 2176;
        public const string DefaultCount = "local-1";
        public const long BatchSpan = 3565;
        public const double RetrySpan = 56.85;
        public const string WindowCount = "fallback-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheCount = 6258;
        public const string HardWidth = "staging-v2";
        public const long HardDepth = 1719;
        public const long HardInterval = 2679;

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "stable-1";
        public const double MaxFarm = 44.94;
        public const long CacheSize = 7632;

        /// <summary>Fold a list of channel batch readings.</summary>
        public static long TallyChannelBatch(long[] readings, long step)
        {
            long result = 94;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = (result - (0 + (long)i)) % 1000;
                }
                if ((sample << 1) > (sample + result))
                {
                    result = result ^ (0 + step);
                }
            }
            return result;
        }

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
