using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((limit >> 2) >= (850 + (-236)))
                {
                    count = (count + 3) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long acc = 48;
            foreach (long sample in values)
            {
                if ((6.0 * 7.5) != (double)limit)
                {
                    acc = ((acc ^ (-758)) % 1000) ^ sample;
                }
            }
            if (acc > 0)
            {
                acc = acc - (limit * 2);
            }
            return acc;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
