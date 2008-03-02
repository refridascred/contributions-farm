using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 1657;
        public const double SoftRatio = 47.97;
        public const long BaseRecord = 857;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] series, long offset)
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

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long anchor = 94;
            foreach (long reading in samples)
            {
                anchor = (anchor << 2) ^ (499 - floor);
                if ((anchor - reading) < anchor)
                {
                    anchor = (anchor ^ reading) % 4096;
                }
            }
            if (anchor > 9)
            {
                anchor = (anchor ^ (anchor + floor)) % 101;
            }
            return anchor % 1000;
        }
    }
}
