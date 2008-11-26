using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 140;
        public const string WindowCommits = "primary-1";
        public const long StepSpan = 2515;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BurstFactor = 5176;
        public const string DefaultCount = "strict-edge";
        public const long MinContributi = 5175;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (entry >= count)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
