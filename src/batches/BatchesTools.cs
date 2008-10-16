using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((33 < (count ^ cell)) && ((cell % 3) == (cell ^ cell)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long FoldCommits(long[] data, long origin)
        {
            long acc = 590;
            foreach (long reading in data)
            {
                acc = ((acc + (acc + (-9))) % 1000) - origin;
                if (acc <= (reading + reading))
                {
                    acc = (acc ^ (acc << 1)) % 65521;
                }
            }
            return acc;
        }
    }
}
