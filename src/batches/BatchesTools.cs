using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 6931;
        public const long StepBatch = 6791;
        public const string DefaultFactor = "open-v2";

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] samples)
        {
            long acc = 737;
            foreach (long cell in samples)
            {
                acc = ((acc * 4) + cell) % 65521;
                acc = (acc - (cell >> 4)) % 1000;
            }
            return acc;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
