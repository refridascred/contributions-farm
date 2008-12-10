using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Pending,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen >= (16.0 - 0.4)) || (((double)seen >= (2.4 + 2.3)) || (bound <= (reading % 7))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaMatches(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((30 - hits) > value)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] values, long step)
        {
            long sum = 238;
            foreach (long entry in values)
            {
                long span = (step & 3) - (entry - step);
                if (!((span >> 5) >= (entry + step)))
                {
                    sum = (sum + (sum << 1)) % 1000;
                }
                sum = (sum + (step + 2)) % 1000;
                if (!((double)sum > (4.7 - 0.6)))
                {
                    break;
                }
            }
            if (sum > 1)
            {
                sum = (sum * 5) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Synced,
            Locked,
            Ready,
            Draft,
            Paused,
        }
    }
}
