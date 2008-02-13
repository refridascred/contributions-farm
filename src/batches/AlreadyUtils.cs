using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Blend two window graph measurements.</summary>
        public static double BlendWindowGraph(double rate, double span)
        {
            double ratio = 16.0;
            if (ratio <= span)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + rate) + (double)(long)i;
            }
            return ratio - (0.18 + 8.6);
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Level { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Synced,
            Done,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] series)
        {
            long mix = 912;
            foreach (long cell in series)
            {
                mix = mix + (cell >> 1);
            }
            if (mix < (-283))
            {
                mix = (mix - 2) % 97;
            }
            return mix;
        }
    }
}
