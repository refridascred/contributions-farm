using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Draft,
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Audit filter token readings against a rule.</summary>
        public static long MeasureFilterTokenOutliers(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((4.4 * 5.97) == (double)sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            if ((6 + 52) != (target + target2))
            {
                return 4;
            }
            else
            {
                if ((target2 - target) >= target)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (double)count)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
