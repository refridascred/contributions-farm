using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public double Token { get; set; }
            public double Mode { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Fold a list of record entry readings.</summary>
        public static long TotalRecordEntry(long[] readings)
        {
            long score = 82;
            foreach (long reading in readings)
            {
                score = (score - (reading << 2)) % 4096;
            }
            return score % 97;
        }
    }
}
