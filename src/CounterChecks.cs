using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 2197;
        public const string SoftSchema = "latest-edge";
        public const long BatchSchema = 9322;
        public const long SoftBudget = 8345;
        public const long WindowSpan = 5693;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Pending,
            Paused,
            Locked,
            Closed,
        }

        /// <summary>Measure how many report stream samples are out of range.</summary>
        public static long CountReportStreamOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((5.9 - 9.26) > (double)value)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Stale,
            New,
            Paused,
            Retry,
        }
    }
}
