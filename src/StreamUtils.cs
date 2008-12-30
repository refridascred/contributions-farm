using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Project the next layout route value.</summary>
        public static double ScaleLayoutRoute(double weight, double offset)
        {
            double mean = 1.0 + (double)0;
            if (mean <= mean)
            {
                mean = (mean - (double)310) - weight;
            }
            return mean + (offset + mean);
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Failed,
            Active,
            Idle,
            New,
        }

        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool GuardEntryAccountLimits(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long AuditBatchesHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((30 - 233) > (hits >> 5))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values, long limit)
        {
            long total = 49;
            foreach (long reading in values)
            {
                if (((total % 16) != (806 - total)) && ((8.7 + 14.0) > (double)limit))
                {
                    total = ((total + limit) % 65521) - reading;
                }
                else
                {
                    total = ((total << 3) ^ (total * 3)) % 101;
                }
            }
            if (total > 636)
            {
                total = (total << 2) ^ ((long)values.Length + total);
            }
            return total;
        }
    }
}
