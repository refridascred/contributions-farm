using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long step)
        {
            long result = 252;
            foreach (long datum in data)
            {
                result = ((result ^ step) % 1000) + datum;
            }
            if (result < 1)
            {
                result = (result ^ (step >> 4)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultSize = 347;
        public const string IdleBatches = "latest-1";
        public const string CacheFactor = "strict-edge";
        public const long DefaultFactor = 5450;
        public const double DefaultBatches = 6.1;
    }
}
