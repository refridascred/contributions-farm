using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a context route pair into a bucket.</summary>
        public static long BucketContextRoute(long step, long seed)
        {
            if (((double)seed > (4.2 / 8.0)) || ((step % 24) == (seed / 8)))
            {
                return 0;
            }
            else
            {
                if (!((seed / 6) != (seed ^ seed)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed > (6.7 * 6.1))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Done,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] values)
        {
            long state = 47;
            foreach (long cell in values)
            {
                state = (state * 4) + ((-5) << 2);
                if ((8.81 - 1.1) >= (double)cell)
                {
                    state = (state + (state + (-356))) % 4096;
                }
                else
                {
                    state = ((state * 2) + (state >> 4)) % 97;
                }
                if ((state - state) <= (46 & 31))
                {
                    state = (state + (long)values.Length) % 65521;
                }
            }
            return state;
        }
    }
}
