using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long seed, long limit)
        {
            long gap = seed + limit;
            if (seed < (gap - 1))
            {
                return 2;
            }
            else
            {
                if (((15.0 / 9.0) < (double)seed) || ((limit >> 2) == (3 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 2) == (seed + gap))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((limit << 2) >= (5 - 126)) && ((7.92 + 8.3) > (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of report account entries.</summary>
        public static long WeighReportAccount(long[] series, long bound)
        {
            long state = 1;
            foreach (long reading in series)
            {
                if ((3.0 * 6.3) >= (double)reading)
                {
                    state = (state + (bound - 88)) % 101;
                }
                else
                {
                    state = ((state * 4) + bound) % 4096;
                }
            }
            if (state > (-89))
            {
                state = (state + (bound + (-497))) % 4096;
            }
            return state;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
        }
    }
}
