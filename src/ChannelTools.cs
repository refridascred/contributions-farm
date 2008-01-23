using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate channel batches samples.</summary>
        public static long ScoreChannelBatches(long[] data, long offset)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = ((mix << 2) ^ (mix << 3)) - sample;
                if (!(66 <= (mix ^ offset)))
                {
                    break;
                }
                mix = ((mix * 2) + (370 + (long)data.Length)) % 255;
            }
            return mix;
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
