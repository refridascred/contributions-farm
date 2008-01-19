using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 3035;
        public const long StepSize = 5335;
        public const double RetryLevel = 24.07;
        public const double IdleDepth = 29.5;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Queued,
            Done,
            New,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 4600;
        public const long DefaultChannel = 7152;
        public const string MaxRatio = "fallback";
        public const string IdleTimeout = "local";

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTimeout = 5936;
        public const long BatchRatio = 6995;
        public const long IdleTools = 3689;
        public const string BaseScore = "fallback-1";

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
