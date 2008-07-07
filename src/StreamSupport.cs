using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseDepth = 7344;
        public const double StepAlready = 69.95;
        public const long MinAlready = 2641;

        /// <summary>Define profile limits and defaults.</summary>
        public const string HardProfile = "primary";
        public const string HardRatio = "staging-v2";
        public const double MaxProfile = 30.94;
        public const string MaxDepth = "standard";

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool CheckBufferContributiBounds(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
