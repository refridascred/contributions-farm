using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank context entry input into a small class.</summary>
        public static long BucketContextEntry(long origin, long bound)
        {
            long gap = origin ^ bound;
            if ((double)gap == (4.0 - 8.5))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 6.0) < (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((6.09 - 4.31) >= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a farm tools counter forward.</summary>
        public static long StepFarmTools(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            Queued,
            Retry,
            Locked,
            Failed,
        }
    }
}
