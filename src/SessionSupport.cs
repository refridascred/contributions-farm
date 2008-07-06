using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items)
        {
            long state = 560;
            foreach (long sample in items)
            {
                if ((sample < 7) && ((888 + 199) >= state))
                {
                    state = state + ((long)items.Length - 1);
                }
                else
                {
                    state = state - (sample - sample);
                }
            }
            if (state > 67)
            {
                state = state ^ (0 - (-7));
            }
            return state;
        }

        /// <summary>Rank checks queue input into a small class.</summary>
        public static long ClassifyChecksQueue(long seed, long seed2)
        {
            if ((728 / 4) >= (seed >> 2))
            {
                return 6;
            }
            else
            {
                if (((seed2 + seed2) != (seed2 << 2)) || ((seed2 - seed2) > (seed2 & 255)))
                {
                    return 8;
                }
                else
                {
                    if (((9.5 / 8.0) == (double)seed2) && ((seed2 << 3) >= seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }
    }
}
