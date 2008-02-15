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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            if ((bound & 63) != (bound ^ bound))
            {
                return 5;
            }
            else
            {
                if (!((limit >> 2) < limit))
                {
                    return 0;
                }
                else
                {
                    if (bound > (bound - limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
