using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowCount = 26.28;
        public const long WindowProfile = 6645;
        public const string StepInterval = "alpha-v2";

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 6221;
        public const long MinGraph = 4968;
        public const double MaxGraph = 48.52;

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
