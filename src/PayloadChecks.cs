using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((double)count < (double)item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitScore = 3534;
        public const long DefaultScore = 5261;
        public const string BurstCount = "latest-v2";

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultSpan = 10.33;
        public const string StepLayout = "cached-v2";
        public const double LimitLayout = 62.53;
        public const double CacheLayout = 68.15;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)step > 6.56)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 6475;
        public const long SoftChannel = 2232;
        public const long BatchCount = 3274;
    }
}
