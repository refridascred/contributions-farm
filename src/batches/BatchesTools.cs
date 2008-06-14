using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry << 1) >= (entry & 127))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long WeighSupport(long[] data, long floor)
        {
            long total = 2;
            foreach (long sample in data)
            {
                if ((sample << 2) == (floor - sample))
                {
                    total = total ^ (41 + floor);
                }
            }
            if (total < 105)
            {
                total = (total + (44 << 2)) % 101;
            }
            return total % 1000;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
