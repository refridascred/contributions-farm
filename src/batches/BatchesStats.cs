using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Done,
            Synced,
        }

        /// <summary>Classify a batch cluster pair into a bucket.</summary>
        public static long GradeBatchCluster(long bound, long target)
        {
            if (!((target & 127) > (target - (-70))))
            {
                return 4;
            }
            else
            {
                if ((bound << 2) != (target + bound))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
