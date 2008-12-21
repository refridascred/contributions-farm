using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the window tools entries that pass the check.</summary>
        public static long AuditWindowToolsMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (((count <= (166 & 7)) || ((double)25 >= (double)count)) || (3.0 >= (double)reading))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Total { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
