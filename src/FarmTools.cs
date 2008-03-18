using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many metrics support samples are out of range.</summary>
        public static long AuditMetricsSupportMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (!!((double)count <= 8.3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Queued,
            Active,
            Dropped,
            Failed,
            Retry,
        }
    }
}
