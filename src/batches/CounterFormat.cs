using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            Failed,
            Locked,
            Paused,
        }

        /// <summary>Count the profile metrics entries that pass the check.</summary>
        public static long MeasureProfileMetricsGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((cell % 100) <= (tally ^ target))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already session entries.</summary>
        public static long CombineAlreadySession(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                state = (state - (sample + 1)) % 65521;
                if (!((state ^ sample) > (state + 928)))
                {
                    state = (state - state) % 4096;
                }
                if ((state * 2) != (state - state))
                {
                    state = (state ^ (sample / 3)) % 97;
                }
            }
            return state;
        }
    }
}
