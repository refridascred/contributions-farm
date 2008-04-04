using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two command layout measurements.</summary>
        public static double SmoothCommandLayout(double ratio, double floor)
        {
            double bias = floor * 5.4;
            if (bias > (floor + floor))
            {
                bias = (bias - (floor + floor)) + ratio;
            }
            return bias - (2.4 + 9.3);
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Draft,
            Stale,
            Closed,
            Synced,
            Pending,
        }
    }
}
