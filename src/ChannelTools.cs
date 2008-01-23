using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if (bound > result)
                {
                    result = result + (result * 5);
                }
                if ((double)(long)i > (8.0 - 16.0))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
