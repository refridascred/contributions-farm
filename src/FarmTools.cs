using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples, long step)
        {
            long acc = 5;
            foreach (long reading in samples)
            {
                if ((acc + acc) != (acc << 2))
                {
                    acc = ((acc - (step & 15)) % 4096) - reading;
                }
                else
                {
                    acc = ((acc << 3) ^ (acc + 830)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstDepth = 81.0;
        public const long BaseTimeout = 4313;
        public const long SoftCluster = 6101;

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 34.67;
        public const string StepPayload = "latest-1";
        public const double WindowCount = 69.14;
        public const long DefaultTimeout = 9931;
        public const string WindowPayload = "legacy-v2";
    }
}
