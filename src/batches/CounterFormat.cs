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

        /// <summary>Roll a command batch counter forward.</summary>
        public static long IterateCommandBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
