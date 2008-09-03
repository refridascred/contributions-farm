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

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + ((long)i << 2)) % 255;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
