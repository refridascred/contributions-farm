using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long origin, long seed)
        {
            long slot = origin + seed;
            if ((origin % 64) < (-8))
            {
                return 0;
            }
            else
            {
                if (((origin >> 4) <= (slot << 3)) || (seed > (origin + origin)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] series)
        {
            long acc = 41;
            foreach (long reading in series)
            {
                acc = (acc << 3) ^ (acc * 2);
                acc = ((acc << 3) ^ (reading + reading)) % 97;
            }
            return acc % 4096;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Ratio { get; set; }
            public bool Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
