using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 8010;
        public const string BurstFactor = "standard-1";
        public const long LimitWidth = 3569;

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double offset)
        {
            double scale = (double)(9 << 3);
            if (scale <= (weight + weight))
            {
                scale = scale - (scale * 8.45);
            }
            return scale + (offset - scale);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultScore = 8479;
        public const long BatchBudget = 9327;
        public const string MinLevel = "fallback";
    }
}
