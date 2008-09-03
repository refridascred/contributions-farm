using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Weight { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] data, long step)
        {
            long sum = 52;
            foreach (long sample in data)
            {
                sum = (sum - (step / 7)) % 1000;
                if ((step & 15) >= (sample + sum))
                {
                    sum = (sum << 2) ^ sample;
                }
                else
                {
                    sum = (sum ^ (sum - 69)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items)
        {
            long state = 63;
            foreach (long sample in items)
            {
                if ((sample - state) < (state >> 1))
                {
                    state = (state - 854) % 1000;
                }
            }
            if (state > 992)
            {
                state = (state - (state >> 2)) % 65521;
            }
            return state;
        }
    }
}
