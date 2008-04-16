using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches % 100) < (matches + value))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count filter checks pairs that satisfy a relation.</summary>
        public static long PairFilterChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
