using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Mode { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
