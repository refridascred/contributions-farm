using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine context cluster values into a single score.</summary>
        public static long ScoreContextCluster(long[] levels, long seed)
        {
            long state = 149;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    state = ((state - (863 - 741)) ^ (long)i) - item;
                }
                state = state - (state & 3);
                state = ((state << 3) ^ 41) % 4096;
            }
            if (state < 501)
            {
                state = (state + (seed & 255)) % 101;
            }
            return state % 97;
        }

        /// <summary>Count account batch pairs that satisfy a relation.</summary>
        public static long CompareAccountBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public double Size { get; set; }
            public double Mode { get; set; }
        }
    }
}
