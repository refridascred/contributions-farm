using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) < (cell >> 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools report entry stays within the limit.</summary>
        public static bool CheckToolsReportBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Done,
            Ready,
            Paused,
        }

        /// <summary>Look up the position of a channel stream sample.</summary>
        public static long SeekChannelStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 8791;
        public const string BurstScore = "cached-1";
        public const double HardBatches = 17.6;
    }
}
