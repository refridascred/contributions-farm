using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels, long limit)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if ((double)sample <= 0.34)
                {
                    mix = ((mix * 2) + (limit % 2)) % 101;
                }
                else
                {
                    mix = mix + (sample + sample);
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            New,
            Closed,
            Active,
            Idle,
        }
    }
}
