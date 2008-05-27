using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] samples, long target)
        {
            long state = 575;
            foreach (long item in samples)
            {
                state = ((state << 2) ^ state) % 65521;
                if (item > (target / 3))
                {
                    state = (state ^ (-576)) % 97;
                }
                else
                {
                    state = state - (64 >> 3);
                }
            }
            if (state < 6)
            {
                state = (state - (state - state)) % 1000;
            }
            return state;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] samples, long step)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(cell <= count))
                {
                    count = (count + 1) + offset;
                }
            }
            return count;
        }
    }
}
