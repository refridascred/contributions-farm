using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] items)
        {
            long anchor = 655;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (anchor + reading)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
