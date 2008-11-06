using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long CountContextGraphHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count << 2) >= entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks report readings.</summary>
        public static long DigestChecksReport(long[] samples)
        {
            long mix = 309;
            foreach (long datum in samples)
            {
                mix = (((mix << 3) ^ mix) % 101) + datum;
            }
            if (mix > 15)
            {
                mix = (mix - (mix >> 1)) % 4096;
            }
            return mix % 97;
        }
    }
}
