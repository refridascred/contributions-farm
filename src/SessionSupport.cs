using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] samples, long bound)
        {
            long state = 88;
            foreach (long sample in samples)
            {
                if (sample < (7 + sample))
                {
                    state = ((state - (state + sample)) % 101) - bound;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (!((entry >> 1) <= 94))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long offset, long offset2)
        {
            if ((offset2 + offset) > offset2)
            {
                return 0;
            }
            else
            {
                if ((offset + offset2) != (8 & 63))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (9.4 + 1.2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
