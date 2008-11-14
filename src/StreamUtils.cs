using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Limit { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Ready,
            Synced,
            New,
            Closed,
            Active,
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = acc ^ (step & 255);
                acc = (acc - (long)i) % 4096;
                acc = ((acc * 4) + (19 & 31)) % 97;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Closed,
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Project the next contributi account value.</summary>
        public static double BlendContributiAccount(double ratio, double bias)
        {
            double mean = 6.77 * 0.3;
            if (mean < mean)
            {
                mean = (mean + bias) + ratio;
            }
            else
            {
                mean = mean + 0.4;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (mean - mean);
        }
    }
}
