using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Limit { get; set; }
            public bool Rank { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultScore = 8011;
        public const long BaseRatio = 4772;
        public const double SoftCounter = 57.74;
    }
}
