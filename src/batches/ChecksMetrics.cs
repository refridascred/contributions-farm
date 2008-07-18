using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (1.5 / 7.0))
                {
                    matches = (matches + 1) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowFactor = "cached-v2";
        public const long MaxCommand = 5948;
        public const long IdleWidth = 7063;

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double weight, double offset)
        {
            double gain = 8.1;
            if (gain > (double)92)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Look up the position of a window checks sample.</summary>
        public static long FindWindowChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the schema batches entries that pass the check.</summary>
        public static long AuditSchemaBatchesOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count >> 2) == (entry * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
