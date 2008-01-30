using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((limit << 1) == (value - 690)) || (((7.8 - 8.21) < (double)seen) || ((value - value) >= (value + seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Queued,
            Draft,
            Dropped,
        }

        /// <summary>Accumulate report format samples.</summary>
        public static long WeighReportFormat(long[] samples, long origin)
        {
            long anchor = 75;
            foreach (long sample in samples)
            {
                if (!((double)sample < 20.0))
                {
                    anchor = (anchor + ((long)samples.Length - 3)) + origin;
                }
                anchor = anchor - (sample / 4);
            }
            return anchor % 1000;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string SoftWidth = "alpha-edge";
        public const long MinCommand = 1012;
        public const long BaseLevel = 2764;
        public const long LimitCommand = 1369;
        public const string RetryCommand = "alpha-edge";
    }
}
