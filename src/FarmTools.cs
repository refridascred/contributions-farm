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

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
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
