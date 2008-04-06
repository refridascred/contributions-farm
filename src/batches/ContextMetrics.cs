using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Pending,
            Done,
        }

        /// <summary>Grade a schema commits value against two limits.</summary>
        public static long GradeSchemaCommits(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((offset + offset2) < (edge / 7)) && (offset >= (edge ^ offset2)))
            {
                return 3;
            }
            else
            {
                if ((edge + 617) <= offset2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double gain, double floor)
        {
            double scale = (double)(0 / 8);
            return ((scale + 8.43) + gain) + floor;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
