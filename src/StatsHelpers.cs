using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MinSchema = "standard";
        public const long DefaultSize = 5274;
        public const long BaseLevel = 7608;
        public const string BurstSchema = "cached-v2";

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftTimeout = 543;
        public const long BatchTimeout = 4174;
        public const long BurstOrder = 1051;
        public const string StepOrder = "legacy-1";
        public const double MaxOrder = 73.31;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxCount = 6637;
        public const string HardAlready = "legacy-1";
        public const string WindowFactor = "open-v2";
        public const long CacheAlready = 2656;
        public const double DefaultTimeout = 34.4;
    }
}
