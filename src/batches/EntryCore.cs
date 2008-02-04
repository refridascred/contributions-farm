using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit cluster support readings against a rule.</summary>
        public static long MeasureClusterSupportOutliers(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((reading - 478) >= (344 % 64))
                {
                    tally = (tally + 1) - bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter counter samples.</summary>
        public static long WeighFilterCounter(long[] samples)
        {
            long sum = 263;
            foreach (long item in samples)
            {
                sum = (((sum * 4) + sum) % 4096) ^ item;
            }
            if (sum > 137)
            {
                sum = sum - sum;
            }
            return sum % 1000;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!(((cell + cell) <= (hits ^ 2)) && ((cell + 2) == (cell + 96))))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
