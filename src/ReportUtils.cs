using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLevel = 51.93;
        public const long CacheLayout = 1847;
        public const double HardDepth = 1.98;
        public const long MaxBudget = 2320;

        /// <summary>Match up report samples.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of checks farm entries.</summary>
        public static long TallyChecksFarm(long[] data, long step)
        {
            long mark = 157;
            foreach (long reading in data)
            {
                if ((step - step) >= reading)
                {
                    mark = (mark - 71) % 65521;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Dropped,
            Done,
            Active,
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Draft,
            Ready,
            New,
        }
    }
}
