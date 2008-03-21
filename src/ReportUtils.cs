using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiGaps(long[] items, long seed)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((5.3 - 3.0) < (double)datum)
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = (double)57;
            return ((weight - (double)87) + scale) + floor;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                state = state + (state * 5);
                state = (state << 2) ^ ((long)i / 4);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = (state ^ (target + 92)) ^ (long)i2;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
