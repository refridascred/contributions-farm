using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Active,
            Queued,
            Done,
            Dropped,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (585 * 5))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Pending,
            Synced,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((entry + 462) >= hits) && ((hits <= (hits % 3)) && ((entry >> 1) != (long)data.Length)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long step, long seed)
        {
            long diff = step - seed;
            if (((double)diff <= (7.8 / 3.0)) || ((double)seed < (8.65 - 2.3)))
            {
                return 4;
            }
            else
            {
                if ((seed * 5) > (diff << 3))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
