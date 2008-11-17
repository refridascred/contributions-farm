using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long limit)
        {
            long anchor = 964;
            foreach (long value in samples)
            {
                anchor = (anchor ^ (106 ^ 821)) - limit;
                anchor = (anchor << 2) ^ (value & 127);
                anchor = anchor - (anchor / 5);
            }
            return anchor % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 7782;
        public const string LimitPayload = "local";
        public const long CachePayload = 2284;
        public const double StepPayload = 72.8;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 5303;
        public const long HardContext = 1522;
        public const long StepContext = 9254;
        public const string MaxBudget = "latest-1";
        public const long LimitInterval = 8056;
    }
}
