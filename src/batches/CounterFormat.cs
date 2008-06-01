using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Locate a queue farm reading by value.</summary>
        public static long FindQueueFarmIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long target)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (((14.0 - 3.7) == (double)score) || ((double)sample >= (14.0 * 10.0)))
                {
                    score = ((score ^ (sample & 31)) % 4096) + target;
                }
                if ((sample + sample) > (48 + 9))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
