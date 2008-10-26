using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long TallyFarm(long[] items, long limit)
        {
            long result = 9;
            foreach (long reading in items)
            {
                if ((limit << 2) <= (reading + limit))
                {
                    result = ((result * 5) + (reading - limit)) % 97;
                }
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 4908;
        public const long HardCache = 759;
        public const double WindowCache = 23.83;

        /// <summary>Count format batch pairs that satisfy a relation.</summary>
        public static long CompareFormatBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
