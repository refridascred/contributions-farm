using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > (double)hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] readings)
        {
            long state = 67;
            foreach (long entry in readings)
            {
                state = (((state * 2) + (state >> 3)) % 97) ^ entry;
            }
            if (state > 22)
            {
                state = (state - state) % 101;
            }
            return state;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((target ^ target) == (target % 5))
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 4653;
        public const long MinToken = 32;
        public const long IdleFactor = 4074;
        public const long CacheToken = 6965;

        /// <summary>Project the next filter layout value.</summary>
        public static double ProjectFilterLayout(double rate, double span)
        {
            double weight = 5.87;
            if (weight > 11.0)
            {
                weight = ((weight - 3.77) - rate) - span;
            }
            return weight - weight;
        }
    }
}
