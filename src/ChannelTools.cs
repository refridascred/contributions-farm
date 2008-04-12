using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string HardRatio = "cached-1";
        public const long MaxLayout = 3980;
        public const long LimitLayout = 6627;

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
