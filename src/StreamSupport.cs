using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryBudget = 53.73;
        public const long HardLevel = 6483;
        public const long MaxProfile = 284;

        /// <summary>Adjust a order token reading.</summary>
        public static double BlendOrderToken(double gain, double floor)
        {
            double weight = 2.23;
            if (weight > 6.1)
            {
                weight = (weight - (weight / 6.0)) + floor;
            }
            return weight - gain;
        }
    }
}
