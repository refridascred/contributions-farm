using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Pending,
            Idle,
            New,
            Synced,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 5486;
        public const long StepFilter = 1503;
        public const long LimitFactor = 979;
        public const double MaxFilter = 79.36;
    }
}
