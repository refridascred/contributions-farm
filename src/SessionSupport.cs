using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long bound)
        {
            long state = 88;
            foreach (long sample in samples)
            {
                if (sample < (7 + sample))
                {
                    state = ((state - (state + sample)) % 101) - bound;
                }
            }
            return state % 65521;
        }

        /// <summary>Count already channel pairs that satisfy a relation.</summary>
        public static long CompareAlreadyChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6984;
        public const string StepFactor = "standard-edge";
        public const string MaxBatches = "staging-1";
        public const string WindowRatio = "local-edge";
    }
}
