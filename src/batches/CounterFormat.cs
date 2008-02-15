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

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long target, long origin)
        {
            long next = target + origin;
            if (((target % 24) >= (79 - next)) || (((-297) - next) <= (target >> 3)))
            {
                return 0;
            }
            else
            {
                if ((6.3 * 5.17) < (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((origin % 3) < (890 >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((9.25 * 7.0) >= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
