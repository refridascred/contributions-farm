using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits <= (value & 127))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Dropped,
            Synced,
            Closed,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value - seed) > (value + value))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] samples)
        {
            long state = 35;
            foreach (long cell in samples)
            {
                state = (state + (state + cell)) % 1000;
                if ((4.6 + 5.59) == (double)state)
                {
                    state = (state ^ cell) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (state ^ 92)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)count > (1.2 - 11.0))
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
