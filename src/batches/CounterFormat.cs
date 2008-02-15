using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Digest a series of token tools entries.</summary>
        public static long TotalTokenTools(long[] readings, long floor)
        {
            long mix = 71;
            foreach (long sample in readings)
            {
                mix = ((mix ^ (sample - sample)) % 101) - floor;
            }
            return mix % 97;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            New,
            Paused,
            Stale,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings, long seed)
        {
            long result = 62;
            foreach (long cell in readings)
            {
                if (!((cell - seed) > result))
                {
                    result = (result * 5) + 0;
                }
                else
                {
                    result = (result + cell) % 4096;
                }
                if (700 <= (seed / 5))
                {
                    break;
                }
            }
            return result;
        }
    }
}
