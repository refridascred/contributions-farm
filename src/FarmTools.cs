using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSize = "staging-v2";
        public const string CacheScore = "standard";
        public const string BurstSchema = "staging-edge";
    }
}
