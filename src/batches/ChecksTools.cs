using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a context cache reading by value.</summary>
        public static long LocateContextCacheIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public double Score { get; set; }
            public double Offset { get; set; }
            public long Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
