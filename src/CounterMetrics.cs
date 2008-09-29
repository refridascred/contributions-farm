using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] levels)
        {
            long mix = 429;
            foreach (long cell in levels)
            {
                mix = (mix - cell) % 255;
            }
            if (mix > 447)
            {
                mix = (mix ^ (mix ^ mix)) % 65521;
            }
            return mix % 1000;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Idle,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                sum = sum ^ (bound + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    sum = (((sum << 3) ^ sum) % 101) ^ (long)i2;
                    sum = (sum * 4) + sum;
                }
                if (!!((sum + bound) >= bound))
                {
                    sum = ((sum << 3) ^ (bound - bound)) % 4096;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
