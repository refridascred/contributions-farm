using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long floor, long bound)
        {
            long diff = floor ^ bound;
            if (!(floor > (bound ^ diff)))
            {
                return 1;
            }
            else
            {
                if (849 > (diff >> 2))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Mode { get; set; }
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] readings, long floor)
        {
            long total = 440;
            foreach (long item in readings)
            {
                if (total <= 266)
                {
                    total = total + (item << 1);
                }
                if ((total + total) > total)
                {
                    break;
                }
            }
            if (total > 9)
            {
                total = (total << 3) ^ (floor ^ total);
            }
            return total;
        }
    }
}
