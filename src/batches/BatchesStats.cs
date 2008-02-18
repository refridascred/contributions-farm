using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Label { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long origin)
        {
            long result = origin;
            for (int i = 0; i < 20; i++)
            {
                if (!!((double)origin < (6.86 + 0.46)))
                {
                    result = ((result << 3) ^ result) % 101;
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a stream stats sample.</summary>
        public static long LocateStreamStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Owner { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
