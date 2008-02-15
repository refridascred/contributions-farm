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

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (seed - count))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }
    }
}
