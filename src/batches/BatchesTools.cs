using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Validate window session readings against a bound.</summary>
        public static bool VerifyWindowSessionBounds(long[] items, long seed)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((count >> 4) == (item << 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
