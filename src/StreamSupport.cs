using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Closed,
            Paused,
            Failed,
        }

        /// <summary>Compare every pair of payload session readings.</summary>
        public static long PairPayloadSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinScore = 9557;
        public const long DefaultTimeout = 4519;
        public const long RetryFactor = 6805;
        public const double DefaultInterval = 50.35;
        public const long BaseEditor = 528;
    }
}
