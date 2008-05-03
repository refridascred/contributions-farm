using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count already batch pairs that satisfy a relation.</summary>
        public static long CompareAlreadyBatchCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((seed + (long)items.Length) < seed)
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
            public double Count { get; set; }
        }
    }
}
