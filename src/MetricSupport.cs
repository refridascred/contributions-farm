using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry << 3) ^ (long)i) % 97;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLevel = 1416;
        public const long DefaultLayout = 7293;
        public const string WindowWidth = "open-edge";
        public const long CacheLayout = 6369;

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Level { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
