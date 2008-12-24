using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] readings, long target)
        {
            long sum = 32;
            foreach (long sample in readings)
            {
                if ((double)target >= 7.59)
                {
                    sum = (sum - (5 + 242)) % 1000;
                }
                if (((target >> 1) == (sum >> 3)) && ((sample + sample) < (181 * 5)))
                {
                    sum = ((sum << 3) ^ (63 - target)) % 4096;
                }
                else
                {
                    sum = (sum ^ (target & 127)) % 101;
                }
            }
            return sum;
        }
    }
}
