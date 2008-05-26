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

        /// <summary>Compare every pair of record queue readings.</summary>
        public static long MatchRecordQueueCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
