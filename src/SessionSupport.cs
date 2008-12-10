using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of checks batches readings.</summary>
        public static long CombineChecksBatches(long[] series)
        {
            long result = 770;
            foreach (long value in series)
            {
                if (((long)series.Length / 3) > result)
                {
                    result = result ^ result;
                }
                else
                {
                    result = (result * 4) + (value << 3);
                }
            }
            if (result < 973)
            {
                result = (result - (43 - result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 2532;
        public const double WindowSpan = 69.59;
        public const long BatchLevel = 6306;

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
