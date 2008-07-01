using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = (state - offset) % 4096;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] levels)
        {
            long total = 640;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total + entry) ^ (long)i;
                }
                if ((entry <= (total / 9)) || ((entry & 3) >= entry))
                {
                    total = (total - (entry % 64)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total + entry);
                }
            }
            return total;
        }

        /// <summary>Look up the position of a farm window sample.</summary>
        public static long LocateFarmWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine channel batches values into a single score.</summary>
        public static long WeighChannelBatches(long[] samples)
        {
            long acc = -92;
            foreach (long item in samples)
            {
                acc = ((acc - acc) % 101) ^ item;
            }
            return acc;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Stamp { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
