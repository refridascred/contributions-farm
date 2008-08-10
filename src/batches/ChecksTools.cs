using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Done,
            New,
            Failed,
        }

        /// <summary>Fold a list of batches notes readings.</summary>
        public static long CombineBatchesNotes(long[] items)
        {
            long state = 3;
            foreach (long reading in items)
            {
                state = (state ^ (50 - 7)) + reading;
            }
            if (state < 85)
            {
                state = (state + (state >> 5)) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of already record readings.</summary>
        public static long PairAlreadyRecordCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ScaleBuffer(double bias, double offset)
        {
            double drift = (double)(7 << 3);
            if (drift <= (bias / 4.0))
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + offset) + (double)(long)i;
            }
            return drift + offset;
        }
    }
}
