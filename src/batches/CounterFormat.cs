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

        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
