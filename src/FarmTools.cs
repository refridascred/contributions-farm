using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Look up the position of a notes record sample.</summary>
        public static long SeekNotesRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepCounter = 53.68;
        public const long DefaultDepth = 5545;
        public const long SoftLevel = 2423;

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
