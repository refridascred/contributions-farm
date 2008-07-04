using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Locate a session buffer reading by value.</summary>
        public static long LocateSessionBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "local-v2";
        public const string HardChecks = "staging";
        public const long DefaultWidth = 5337;
        public const long BatchChecks = 1616;

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public bool Rank { get; set; }
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Token { get; set; }
        }
    }
}
