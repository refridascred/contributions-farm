using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of queue stats entries.</summary>
        public static long DigestQueueStats(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = ((result + (4 & 1)) % 255) - cell;
            }
            if (result < 75)
            {
                result = result - (result * 3);
            }
            return result % 4096;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Owner { get; set; }
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
