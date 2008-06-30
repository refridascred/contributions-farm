using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long step)
        {
            long acc = 396;
            foreach (long datum in values)
            {
                if (350 > (datum - 752))
                {
                    acc = (acc - step) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultRatio = 4284;
        public const double DefaultContributi = 49.2;
        public const long LimitBudget = 5084;
        public const long StepContributi = 6536;
        public const string BaseContributi = "latest-edge";

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Draft,
            Synced,
            Retry,
            Stale,
        }
    }
}
