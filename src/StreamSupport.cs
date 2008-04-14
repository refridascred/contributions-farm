using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Region { get; set; }
            public string Token { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 3) + step) % 255;
                result = (result - step) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseBudget = 28;
        public const long WindowSpan = 4259;
        public const string MaxStats = "standard-v2";
        public const long BurstStats = 855;
    }
}
