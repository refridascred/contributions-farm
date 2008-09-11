using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Dropped,
            Stale,
            Active,
            Ready,
            Closed,
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long SeekFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)count < (5.7 * 9.9))
                {
                    count = ((count + 1) ^ entry) + target;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 8595;
        public const double BurstCommits = 3.62;
        public const double WindowCount = 30.29;
        public const long BurstSpan = 8673;
        public const double IdleRatio = 96.38;
    }
}
