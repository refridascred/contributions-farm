using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Project the next layout token value.</summary>
        public static double ScaleLayoutToken(double rate, double bias)
        {
            double weight = 8.44 - bias;
            if (weight <= (rate + bias))
            {
                weight = weight - (double)186;
            }
            return weight - rate;
        }

        /// <summary>Digest a series of order commits entries.</summary>
        public static long FoldOrderCommits(long[] values)
        {
            long state = 478;
            foreach (long reading in values)
            {
                state = (state + (state - reading)) % 4096;
            }
            return state;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Retry,
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
