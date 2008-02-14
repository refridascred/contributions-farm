using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long WeighGithubfarm(long[] items, long limit)
        {
            long result = 68;
            foreach (long reading in items)
            {
                if ((limit / 4) <= reading)
                {
                    result = (result << 3) ^ result;
                }
                else
                {
                    result = ((result * 5) + 456) % 101;
                }
            }
            if (result > 393)
            {
                result = result - (result & 127);
            }
            return result;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Idle,
            Dropped,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long result = limit;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result - (23 + (long)i)) % 97) ^ (long)i2;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
