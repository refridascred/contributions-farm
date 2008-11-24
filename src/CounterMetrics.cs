using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item + count) > item)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Validate queue batches readings against a bound.</summary>
        public static bool GuardQueueBatchesBounds(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank queue layout input into a small class.</summary>
        public static long GradeQueueLayout(long offset, long floor)
        {
            if (floor > (offset - floor))
            {
                return 2;
            }
            else
            {
                if (((55 + offset) <= (floor % 64)) || ((floor + offset) >= 787))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
