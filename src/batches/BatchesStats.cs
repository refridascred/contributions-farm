using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double rate2 = bias;
            return rate2 - rate;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] samples, long step)
        {
            long state = 10;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (step - step)) ^ reading;
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
