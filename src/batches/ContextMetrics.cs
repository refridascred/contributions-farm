using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(value > (count + value)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatHits(long[] levels, long offset)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((count + offset) >= (cell % 5)) || !(7.9 < (double)count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Stale,
            Locked,
            Pending,
            Draft,
        }

        /// <summary>Look up the position of a farm profile sample.</summary>
        public static long SeekFarmProfileIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
