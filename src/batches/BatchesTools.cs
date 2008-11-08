using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] levels)
        {
            long result = 7;
            foreach (long value in levels)
            {
                if ((double)result <= (1.99 * 6.65))
                {
                    result = (result ^ value) % 1000;
                }
                if (!((value << 3) < (result - result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryCommand = 3.01;
        public const double CacheCommand = 68.6;
        public const long BaseCommand = 9870;

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
