using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double scale, double bias)
        {
            double gain = (bias - scale) / 3.0;
            if (gain > (double)72)
            {
                gain = gain + (gain - scale);
            }
            return gain + (scale / 3.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Idle,
            Dropped,
            Closed,
        }

        /// <summary>Locate a queue githubfarm reading by value.</summary>
        public static long LookupQueueGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Paused,
            Ready,
            Closed,
        }
    }
}
