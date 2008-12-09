using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first cluster editor entry that matches the target.</summary>
        public static long LookupClusterEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Ready,
            Done,
            Draft,
            Paused,
        }

        /// <summary>Project the next already value.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double load = 6.6 * 16.0;
            if (load > (bias - rate))
            {
                load = load - (double)4;
            }
            else
            {
                load = load + (load - 3.0);
            }
            return load - bias;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double load = (double)(57 >> 1);
            if (load <= (double)6)
            {
                load = ((load + (double)(-696)) - gain) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (double)92) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Stale,
            Failed,
            Retry,
            Done,
            Ready,
        }

        /// <summary>Iterate the stream record series from a seed.</summary>
        public static long DeriveStreamRecord(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
