using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public string Offset { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Active,
            Paused,
            Locked,
        }

        /// <summary>Measure how many checks command samples are out of range.</summary>
        public static long MeasureChecksCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((count << 2) != (574 + sample))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
