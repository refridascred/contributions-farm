using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long target)
        {
            long carry = target;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheCount = 7567;
        public const long CacheFilter = 3332;
        public const long MinWidth = 9539;
        public const long MaxInterval = 9633;
        public const string StepSize = "alpha-1";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryLevel = 9437;
        public const double BasePayload = 86.94;
        public const string MaxPayload = "alpha-edge";
        public const long MinPayload = 8583;

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double ratio = gain;
            if (ratio < gain)
            {
                ratio = (ratio + gain) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (gain - gain)) + (double)(long)i;
            }
            return ratio + (double)819;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
