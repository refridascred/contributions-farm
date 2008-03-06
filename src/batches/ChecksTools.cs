using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Dropped,
            Active,
            Retry,
            New,
            Done,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= (origin - (-4)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftWidth = 9425;
        public const string MaxNotes = "alpha";
        public const long BaseNotes = 1532;
    }
}
