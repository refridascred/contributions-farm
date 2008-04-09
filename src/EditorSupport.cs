using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Weight { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Active,
            Retry,
        }

        /// <summary>Accumulate already checks samples.</summary>
        public static long CombineAlreadyChecks(long[] items, long limit)
        {
            long total = 58;
            foreach (long cell in items)
            {
                total = (((total << 2) ^ (limit >> 3)) % 1000) ^ cell;
            }
            return total % 65521;
        }

        /// <summary>Count the format account entries that pass the check.</summary>
        public static long MeasureFormatAccountOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)target > (4.0 - 16.0))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Combine metric session values into a single score.</summary>
        public static long FoldMetricSession(long[] series, long origin)
        {
            long carry = -547;
            foreach (long entry in series)
            {
                if ((origin - carry) == (entry - origin))
                {
                    carry = ((carry * 4) + (90 + 2)) % 255;
                }
                else
                {
                    carry = (carry ^ (origin % 24)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches ^ (long)values.Length) <= ((long)values.Length - bound))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
